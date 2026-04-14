using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Microsoft.EntityFrameworkCore;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using HospitalManagmentSys.BiussnessLogic;
using System.IO;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Presentation
{
    public partial class Form1 : Form
    {
        // declare the databse context
        private readonly AppDbContext _context = new AppDbContext();
        private bool isAnimationEnabled = true;
        LiveCharts.WinForms.PieChart myPieChart;
        LiveCharts.WinForms.CartesianChart myLineChart;
        private System.Windows.Forms.Timer _pieTimer;
        private List<DateTime> _pieDates;
        private int _pieIndex = 0;

        public Form1()
        {
            InitializeComponent();

            // chart controls are created at runtime below (avoid designer load issues)

            // Set optimal form size for all content
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = false;
            //mainPanel.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 247, 250);


            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Control pieParent = (this.pieChart2 != null) ? (Control)this.pieChart2 : this.guna2CustomGradientPanel1;
                Control cartParent = (this.cartesianChart1 != null) ? (Control)this.cartesianChart1 : this.guna2CustomGradientPanel2;

                myPieChart = new LiveCharts.WinForms.PieChart();
                myLineChart = new LiveCharts.WinForms.CartesianChart();

                // dock charts to fill their panels (matches original designer behavior)
                myPieChart.Dock = DockStyle.Fill;
                myLineChart.Dock = DockStyle.Fill;

                pieParent.Controls.Add(myPieChart);
                cartParent.Controls.Add(myLineChart);

                // load data and populate visuals
                LoadPatientsData();
                UpdateDashboardStats();
                // Setup charts
                SetupPieChart();
                SetupCartesianChart();

                // prepare dates for pie rotation (last 7 days)
                _pieDates = Enumerable.Range(0, 7).Select(i => DateTime.Today.AddDays(-i)).Reverse().ToList();
                _pieIndex = _pieDates.Count - 1; // start with most recent

                // start timer to rotate pie chart daily (every 3 seconds for demo)
                _pieTimer = new System.Windows.Forms.Timer();
                _pieTimer.Interval = 3000; // 3 seconds
                _pieTimer.Tick += (s, ev) =>
                {
                    try
                    {
                        _pieIndex = (_pieIndex + 1) % _pieDates.Count;
                        UpdatePieForDate(_pieDates[_pieIndex]);
                    }
                    catch { }
                };

                // show today's data immediately
                UpdatePieForDate(DateTime.Today);
                _pieTimer.Start();
            }



            guna2DataGridView1.BorderStyle = BorderStyle.None;
            guna2DataGridView1.EnableHeadersVisualStyles = false;
            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 136, 229);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.BackgroundColor = Color.White;

            // runtime-only initialization (avoid running in Visual Studio designer)
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                guna2DataGridView1.CellFormatting += dataGridView1_CellFormatting;
                // Register CellPainting handler for custom drawing of the attendance bar
                guna2DataGridView1.CellPainting += dataGridView1_CellPainting;

                // Improve grid styling for readability
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.AllowUserToAddRows = false;
                guna2DataGridView1.ReadOnly = true;
                guna2DataGridView1.RowHeadersVisible = false;
                guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                // center numeric columns where present (use try-catch for safety)
                try
                {
                    if (guna2DataGridView1.Columns["No_Shows"] != null)
                        guna2DataGridView1.Columns["No_Shows"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (guna2DataGridView1.Columns["Total_Appointments"] != null)
                        guna2DataGridView1.Columns["Total_Appointments"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (guna2DataGridView1.Columns["No_Show_Rate"] != null)
                        guna2DataGridView1.Columns["No_Show_Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                catch
                {
                    // columns may not exist yet; will be aligned after data binding
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // runtime-only operations (safe guard for designer)
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                // Replace department list with compact appointment status summary
                LoadAppointmentStatusSummary();
                PopulateQuickStatistics();
            }
        }


        // Safe runtime-only summary renderer for appointment statuses.
        // Keeps UI simple and avoids designer-time issues.
        private void LoadAppointmentStatusSummary()
        {
            try
            {
                if (mainPanel == null) return;
                mainPanel.Controls.Clear();
                mainPanel.AutoScroll = false;

                var counts = AppointmentServiceForreports.GetAppointmentStatusCounts(_context);
                int pending = counts.pending;
                int confirmed = counts.confirmed;
                int completed = counts.completed;
                int cancelled = counts.cancelled;

                // Create a modern styled card for each status
                int cardY = 12;
                void AddStyledCard(string title, int count, Color bg)
                {
                    var card = new Panel
                    {
                        Size = new Size(mainPanel.Width - 32, 64),
                        Location = new Point(16, cardY),
                        BackColor = bg,
                        BorderStyle = BorderStyle.None
                    };

                    var titleLbl = new Label
                    {
                        Text = title,
                        Location = new Point(12, 8),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                        ForeColor = Color.White,
                        BackColor = Color.Transparent
                    };
                    card.Controls.Add(titleLbl);

                    var countLbl = new Label
                    {
                        Text = count.ToString(),
                        Location = new Point(12, 28),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.Transparent
                    };
                    card.Controls.Add(countLbl);

                    // small percent bar
                    int total = pending + confirmed + completed + cancelled;
                    double pct = total > 0 ? (count / (double)total) : 0;
                    // use a translucent white background for the percent bar (avoid yellow tint)
                    var barBg = new Panel { Location = new Point(card.Width - 160, 24), Size = new Size(120, 12), BackColor = Color.FromArgb(80, 255, 255, 255) };
                    var barFill = new Panel { Location = new Point(card.Width - 160, 24), Size = new Size((int)(120 * pct), 12), BackColor = Color.White };
                    card.Controls.Add(barBg);
                    card.Controls.Add(barFill);

                    mainPanel.Controls.Add(card);
                    card.BringToFront();
                    cardY += 76;
                }

                AddStyledCard("Pending", pending, Color.FromArgb(255, 159, 67));
                AddStyledCard("Confirmed", confirmed, Color.FromArgb(46, 204, 113));
                AddStyledCard("Completed", completed, Color.FromArgb(52, 152, 219));
                AddStyledCard("Cancelled", cancelled, Color.FromArgb(231, 76, 60));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading appointment status summary: " + ex.Message);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = guna2DataGridView1;

            if (grid.Columns[e.ColumnIndex].Name == "No_Shows")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int val) && val > 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "Risk_Level")
            {
                string value = e.Value?.ToString();

                if (value == "High Risk")
                {
                    e.CellStyle.BackColor = Color.FromArgb(231, 76, 60);
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (value == "Warning")
                {
                    e.CellStyle.BackColor = Color.FromArgb(241, 196, 15);
                    e.CellStyle.ForeColor = Color.Black;
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "No_Show_Rate")
            {
                // Move actual painting to CellPainting; in CellFormatting only format the display value
                if (e.Value == null) return;

                if (!float.TryParse(e.Value.ToString(), out float percentage))
                    return;

                // Show a textual percentage in the cell; visual bar is drawn in CellPainting
                e.Value = $"{percentage}%";
                e.FormattingApplied = true;
            }
        }

        // New: handle custom drawing in CellPainting where PaintBackground and Graphics are available
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = guna2DataGridView1;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (grid.Columns[e.ColumnIndex].Name == "No_Show_Rate")
            {
                var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == null) return;

                if (!float.TryParse(cell.Value.ToString(), out float percentage))
                    return;

                // Paint background
                e.PaintBackground(e.CellBounds, true);

                int width = (int)(e.CellBounds.Width * (percentage / 100f));

                // Draw a compact blue bar on the left side
                using (Brush fillBrush = new SolidBrush(Color.FromArgb(30, 136, 229)))
                {
                    int barHeight = 12;
                    int barY = e.CellBounds.Y + (e.CellBounds.Height / 2) - (barHeight / 2);
                    int barX = e.CellBounds.X + 4;
                    int barWidth = Math.Max(0, Math.Min(width - 8, e.CellBounds.Width - 70));
                    e.Graphics.FillRectangle(fillBrush, barX, barY, barWidth, barHeight);
                }

                // Draw percentage text to the right of the bar
                string percentText = $"{percentage:F1}%";
                using (Font textFont = new Font("Segoe UI", 9))
                {
                    e.Graphics.DrawString(percentText, textFont, Brushes.Black,
                        e.CellBounds.X + Math.Max(0, width) + 8, e.CellBounds.Y + 4);
                }

                e.Handled = true;
            }
        }

        private void LoadPatientsData()
        {
            var patients = _context.Patients.ToList();
            guna2DataGridView1.DataSource = patients;
            // Adjust column sizing after binding so content is visible
            try
            {
                for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
                {
                    // make each column auto-size to its content
                    guna2DataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // keep last column flexible to fill remaining space
                if (guna2DataGridView1.Columns.Count > 0)
                    guna2DataGridView1.Columns[guna2DataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch
            {
                // ignore sizing errors at design-time
            }
        }

        // update charts data
        private void UpdateDashboardStats()
        {
            try
            {
                // Total patients
                int totalPatients = _context.Patients.Count();
                guna2HtmlLabel6.Text = totalPatients.ToString();

                // Today's appointments
                DateTime today = DateTime.Today;
                int todaysAppointments = _context.Appointments
                    .Include(a => a.TimeSlot)
                    .Count(a => a.TimeSlot.SlotDate.Date == today);
                guna2HtmlLabel4.Text = todaysAppointments.ToString();

                // Completed appointments today
                int completedToday = _context.Appointments
                    .Include(a => a.TimeSlot)
                    .Count(a => a.TimeSlot.SlotDate.Date == today && a.Status == AppointmentStatus.Completed);
                guna2HtmlLabel11.Text = $"{completedToday} completed";

                // Average wait time (use Attendances if available: CheckInTime - ArriveTime)
                double avgWaitMinutes = 0;
                try
                {
                    var attends = _context.Attendances
                        .Where(at => at.CheckInTime != default && at.ArriveTime != default)
                        .ToList();
                    if (attends.Count > 0)
                    {
                        avgWaitMinutes = attends.Average(at => (at.CheckInTime - at.ArriveTime).TotalMinutes);
                    }
                }
                catch { /* ignore attendance calculation errors */ }

                if (avgWaitMinutes > 0)
                    guna2HtmlLabel2.Text = $"{avgWaitMinutes:F0} min";
                else
                    guna2HtmlLabel2.Text = "N/A";

                // Average no-show / attendance rate across patients
                double avgAttendanceRate = 0;
                var patients = _context.Patients.ToList();
                if (patients.Count > 0)
                {
                    avgAttendanceRate = patients.Average(p => p.AttendanceRate);
                }
                // show no-show rate as (100 - attendance)
                double noShowRate = 100 - avgAttendanceRate;
                guna2HtmlLabel5.Text = $"{noShowRate:F1}%";

                // Doctors count
                guna2HtmlLabel12.Text = _context.Doctors.Count().ToString();

                // High urgency count (kept for internal use) - do not overwrite the "At a glance metrics" label
                int highUrgency = _context.Patients.Count(p => p.MedicalUrgency == MedicalUrgency.High);
                // ensure designer label text stays as intended (avoid showing this numeric value)
                if (guna2HtmlLabel23 != null) guna2HtmlLabel23.Text = "At a glance metrics";

                // Percent change in today's appointments vs yesterday (for small green/red label)
                try
                {
                    DateTime yesterday = today.AddDays(-1);
                    int yesterdayAppointments = _context.Appointments
                        .Include(a => a.TimeSlot)
                        .Count(a => a.TimeSlot.SlotDate.Date == yesterday);

                    double change = 0;
                    if (yesterdayAppointments == 0)
                        change = todaysAppointments * 100; // represent as 100x if previous was zero
                    else
                        change = ((double)(todaysAppointments - yesterdayAppointments) / yesterdayAppointments) * 100.0;

                    string sign = change >= 0 ? "+" : "";
                    guna2HtmlLabel12.Text = $"{sign}{change:F1}%";
                    guna2HtmlLabel12.ForeColor = change >= 0 ? Color.LimeGreen : Color.Red;
                }
                catch { }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error updating dashboard stats: " + ex.Message);
            }
        }

        // setting pateints data depending on genedet of pateints and show it in pie chart
        private void SetupPieChart()
        {
            var genderCounts = _context.Patients
                .GroupBy(p => p.Gender)
                .Select(g => new { Gender = g.Key.ToString(), Count = g.Count() })
                .ToList();

            var series = new SeriesCollection();
            if (genderCounts.Count == 0)
            {
                series.Add(new PieSeries { Title = "No Data", Values = new ChartValues<int> { 1 }, DataLabels = true, Fill = System.Windows.Media.Brushes.LightGray });
            }
            else
            {
                var palette = new[] { System.Windows.Media.Brushes.DeepSkyBlue, System.Windows.Media.Brushes.MediumVioletRed, System.Windows.Media.Brushes.Gold };
                int pi = 0;
                foreach (var item in genderCounts)
                {
                    // keep original gender string (e.g. "Male", "Female")
                    string title = item.Gender;

                    series.Add(new PieSeries
                    {
                        Title = title,
                        Values = new ChartValues<int> { item.Count },
                        DataLabels = true,
                        Fill = palette[pi % palette.Length]
                    });
                    pi++;
                }
            }

            myPieChart.Series = series;
            // restore original visual: small inner radius so pie is visible but not too large
            myPieChart.InnerRadius = 20;
            myPieChart.LegendLocation = LegendLocation.Right;
            myPieChart.DisableAnimations = !isAnimationEnabled ? true : false;
            try
            {
                // Make control visually distinct from panel background
                myPieChart.BackColor = System.Drawing.Color.Transparent;
                // ensure parent panel background is light so slices contrast
                try { myPieChart.Parent.BackColor = System.Drawing.Color.Blue; } catch { }
                myPieChart.Dock = DockStyle.Fill;
            }
            catch { }
            // show data labels and legend mapping
            foreach (var s in myPieChart.Series.OfType<PieSeries>())
            {
                s.DataLabels = true;
                s.LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P1})";
                try
                {
                    // add thin white stroke so slices are separated visually
                    s.Stroke = System.Windows.Media.Brushes.White;
                    s.StrokeThickness = 1.5;
                    s.PushOut = 6;
                    s.FontSize = 14;
                }
                catch { }
            }

            // ensure control is repainted
            try
            {
                myPieChart.BringToFront();
                myPieChart.Invalidate();
                myPieChart.Refresh();
            }
            catch { }
        }

        /// <summary>
        /// Update pie chart to show distribution for a specific date.
        /// By default shows appointments per department on that date.
        /// If no department data present, falls back to gender distribution for the day.
        /// </summary>
        private void UpdatePieForDate(DateTime date)
        {
            try
            {
                // Query appointments on that date and group by department (via doctor)
                var appts = _context.Appointments
                    .Include(a => a.TimeSlot)
                    .Include(a => a.Doctor)
                        .ThenInclude(d => d.Department)
                    .Where(a => a.TimeSlot.SlotDate.Date == date.Date)
                    .AsEnumerable()
                    .ToList();

                var series = new SeriesCollection();

                if (appts.Count == 0)
                {
                    // fallback to gender counts of patients (all patients created on that date or overall)
                    var genderCounts = _context.Patients
                        .GroupBy(p => p.Gender)
                        .Select(g => new { Key = g.Key.ToString(), Count = g.Count() })
                        .ToList();

                    if (genderCounts.Count == 0)
                    {
                        series.Add(new PieSeries { Title = "No Data", Values = new ChartValues<int> { 1 }, Fill = System.Windows.Media.Brushes.LightGray, DataLabels = true });
                    }
                    else
                    {
                        var palette = new[] { System.Windows.Media.Brushes.DeepSkyBlue, System.Windows.Media.Brushes.MediumVioletRed };
                        int pi = 0;
                        foreach (var g in genderCounts)
                        {
                            series.Add(new PieSeries { Title = g.Key, Values = new ChartValues<int> { g.Count }, Fill = palette[pi % palette.Length], DataLabels = true });
                            pi++;
                        }
                    }
                }
                else
                {
                    // group by department name
                    var deptGroups = appts
                        .Where(a => a.Doctor?.Department != null)
                        .GroupBy(a => a.Doctor.Department.Name)
                        .Select(g => new { Dept = g.Key, Count = g.Count() })
                        .ToList();

                    if (deptGroups.Count == 0)
                    {
                        // fallback: group by doctor name
                        var docGroups = appts.GroupBy(a => a.Doctor?.User?.Name ?? "Unknown")
                            .Select(g => new { Dept = g.Key, Count = g.Count() })
                            .ToList();

                        var palette = new[] { System.Windows.Media.Brushes.DeepSkyBlue, System.Windows.Media.Brushes.MediumVioletRed, System.Windows.Media.Brushes.Gold };
                        int pi = 0;
                        foreach (var d in docGroups)
                        {
                            series.Add(new PieSeries { Title = d.Dept, Values = new ChartValues<int> { d.Count }, Fill = palette[pi % palette.Length], DataLabels = true });
                            pi++;
                        }
                    }
                    else
                    {
                        var palette = new[] { System.Windows.Media.Brushes.DodgerBlue, System.Windows.Media.Brushes.MediumSeaGreen, System.Windows.Media.Brushes.Gold, System.Windows.Media.Brushes.MediumVioletRed };
                        int pi = 0;
                        foreach (var d in deptGroups)
                        {
                            series.Add(new PieSeries { Title = d.Dept, Values = new ChartValues<int> { d.Count }, Fill = palette[pi % palette.Length], DataLabels = true });
                            pi++;
                        }
                    }
                }

                // Apply to chart
                myPieChart.Series = series;
                myPieChart.InnerRadius = 20;
                myPieChart.LegendLocation = LegendLocation.Right;
                try { myPieChart.Parent.BackColor = System.Drawing.Color.White; } catch { }
                myPieChart.Dock = DockStyle.Fill;
                foreach (var s in myPieChart.Series.OfType<PieSeries>())
                {
                    s.DataLabels = true;
                    s.LabelPoint = cp => $"{cp.Y} ({cp.Participation:P1})";
                    try { s.Stroke = System.Windows.Media.Brushes.White; s.StrokeThickness = 1.5; s.PushOut = 6; s.FontSize = 14; } catch { }
                }

                // update title label to show date
                try
                {
                    // find the label in designer and set text if available
                    if (this.guna2HtmlLabel16 != null)
                        this.guna2HtmlLabel16.Text = $"No-Shows by Day ({date:yyyy-MM-dd})";
                }
                catch { }

                try { myPieChart.Refresh(); } catch { }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error updating pie for date: " + ex.Message);
            }
        }

        // Cartesian chart: show number of appointments per department
        private void SetupCartesianChart()
        {
            try
            {
                if (myLineChart == null) return;

                // 1) Clear existing series and axes
                myLineChart.Series.Clear();
                myLineChart.AxisX.Clear();
                myLineChart.AxisY.Clear();

                // 2) Pull real data from the database grouped by Doctor.Department.Name
                var deptData = _context.Appointments
                    .Include(a => a.Doctor).ThenInclude(d => d.Department)
                    .AsEnumerable() // bring to memory so we can safely test nulls
                    .Where(a => a.Doctor != null && a.Doctor.Department != null)
                    .GroupBy(a => a.Doctor.Department.Name)
                    .Select(g => new { DeptName = g.Key ?? "Unknown", Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .ToList();

                var values = new ChartValues<int>();
                var labels = new List<string>();

                // 3) Fallback sample data if DB returned no results
                if (deptData.Any())
                {
                    foreach (var item in deptData)
                    {
                        labels.Add(item.DeptName);
                        values.Add(item.Count);
                    }
                }
                else
                {
                    var sampleLabels = new[] { "Cardiology", "Pediatrics", "Orthopedics", "Dermatology", "General Medicine" };
                    var sampleValues = new[] { 12, 8, 6, 4, 10 };
                    labels.AddRange(sampleLabels);
                    foreach (var v in sampleValues) values.Add(v);
                }

                // 4) Create ColumnSeries and configure AxisX labels
                var columnSeries = new ColumnSeries
                {
                    Title = "Appointments",
                    Values = values,
                    Fill = System.Windows.Media.Brushes.DodgerBlue,
                    MaxColumnWidth = 60,
                    DataLabels = true
                };

                myLineChart.Series = new SeriesCollection { columnSeries };

                myLineChart.AxisX.Add(new Axis
                {
                    Title = "Department",
                    Labels = labels.ToArray(),
                    LabelsRotation = 10,
                    Separator = new Separator { Step = 1 }
                });

                myLineChart.AxisY.Add(new Axis
                {
                    Title = "Count",
                    LabelFormatter = value => value.ToString("N0"),
                    MinValue = 0
                });

                myLineChart.DisableAnimations = !isAnimationEnabled;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Chart Error: " + ex.Message);
            }
        }


        private void AddDepartmentItemCompact(Guna.UI2.WinForms.Guna2CustomGradientPanel parent, string departmentName, double attendance, int yPos)
        {
            // Department name label (compact)
            var deptNameLabel = new Label
            {
                Text = departmentName,
                Location = new Point(12, yPos),
                Size = new Size(280, 18),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(60, 60, 60),
                BackColor = Color.Transparent
            };
            parent.Controls.Add(deptNameLabel);

            // Attendance percentage label (on the right)
            var attendanceLabel = new Label
            {
                Text = $"{attendance:F1}%",
                Location = new Point(250, yPos),
                Size = new Size(45, 18),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 136, 229),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.TopRight
            };
            parent.Controls.Add(attendanceLabel);

            // Progress bar background (light gray)
            var bgBar = new Label
            {
                Location = new Point(12, yPos + 20),
                Size = new Size(283, 6),
                BackColor = Color.FromArgb(235, 235, 235),
                BorderStyle = BorderStyle.None
            };
            parent.Controls.Add(bgBar);

            // Progress bar fill (red for low, yellow for high)
            Color barColor = attendance >= 80 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(244, 67, 54);
            int fillWidth = (int)(283 * (attendance / 100.0));

            var fillBar = new Label
            {
                Location = new Point(12, yPos + 20),
                Size = new Size(Math.Max(0, fillWidth), 6),
                BackColor = barColor,
                BorderStyle = BorderStyle.None
            };
            parent.Controls.Add(fillBar);
        }

        /// <summary>
        /// Populates the Quick Statistics panel with real data from database.
        /// Updates the designer-based stat cards with current metrics.
        /// </summary>
        private void PopulateQuickStatistics()
        {
            try
            {
                // Query database for statistics
                double attendanceRate = CalculateAttendanceRate();      // Green card
                int totalNoShows = GetTotalNoShows();                   // Red card
                string peakNoShowDay = GetPeakNoShowDay();              // Blue card
                int atRiskPatientCount = GetAtRiskPatientCount();       // Yellow/Tan card

                // Update stat card values in the designer-based guna2CustomGradientPanel4
                // The stat cards are: guna2CustomGradientPanel5-8 with value labels

                // Find value labels within each stat card and update them
                // Stat 1 (Green - Attendance Rate): guna2CustomGradientPanel5
                UpdateStatCardValue(guna2CustomGradientPanel5, $"{attendanceRate:F1}%");

                // Stat 2 (Red - Total No-Shows): guna2CustomGradientPanel6
                UpdateStatCardValue(guna2CustomGradientPanel6, totalNoShows.ToString());

                // Stat 3 (Blue - Peak No-Show Day): guna2CustomGradientPanel7
                UpdateStatCardValue(guna2CustomGradientPanel7, peakNoShowDay);

                // Stat 4 (Yellow/Tan - At-Risk Patients): guna2CustomGradientPanel8
                UpdateStatCardValue(guna2CustomGradientPanel8, atRiskPatientCount.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error populating quick statistics: " + ex.Message);
            }
        }

        /// <summary>
        /// Helper method to update stat card values in designer-based panels.
        /// </summary>
        private void UpdateStatCardValue(Control panel, string value)
        {
            try
            {
                var labels = new List<Guna.UI2.WinForms.Guna2HtmlLabel>();
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Guna.UI2.WinForms.Guna2HtmlLabel htmlLabel)
                        labels.Add(htmlLabel);
                }

                if (labels.Count >= 2)
                {
                    var valueLabel = labels.FirstOrDefault(l => l.Font.Size > 10);
                    if (valueLabel != null)
                    {
                        // Simple animation using text change
                        if (isAnimationEnabled)
                        {
                            valueLabel.Text = value;
                            valueLabel.ForeColor = Color.FromArgb(100, valueLabel.ForeColor);

                            Task.Run(async () =>
                            {
                                await Task.Delay(100);
                                Invoke(new Action(() =>
                                {
                                    valueLabel.ForeColor = Color.Black;
                                }));
                            });
                        }
                        else
                        {
                            valueLabel.Text = value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error updating stat card: " + ex.Message);
            }
        }

        /// <summary>
        /// Calculates the overall attendance rate from all patients in the database.
        /// Attendance Rate is calculated based on the patient's AttendanceRate property.
        /// </summary>
        private double CalculateAttendanceRate()
        {
            try
            {
                List<Patient> patients = new List<Patient>();
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.DataBoundItem is Patient patient)
                    {
                        patients.Add(patient);
                    }
                }

                if (patients.Count == 0) return 0;

                double averageAttendanceRate = patients.Average(p => p.AttendanceRate);
                return averageAttendanceRate;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error calculating attendance rate: " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Gets the total number of no-shows from all patients.
        /// </summary>
        private int GetTotalNoShows()
        {
            try
            {
                // Get patients from the data grid (mock data)
                int totalNoShows = 0;
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.DataBoundItem is Patient patient)
                    {
                        totalNoShows += patient.NoShowCount;
                    }
                }
                return totalNoShows;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error getting total no-shows: " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Gets the day of the week with the most no-shows.
        /// This is a placeholder - implement based on your appointment scheduling logic.
        /// You may need to join with an Appointments table to get the actual day.
        /// </summary>
        private string GetPeakNoShowDay()
        {
            try
            {
                // For now, returning mock data
                // In production, query from Appointments table where Status = "No-Show"
                // GROUP BY DayOfWeek and find the max count
                return "Friday";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error getting peak no-show day: " + ex.Message);
                return "N/A";
            }
        }

        /// <summary>
        /// Gets the count of patients at high risk (high no-show rate).
        /// High risk is defined as patients with MedicalUrgency = High or AttendanceRate less than 60%
        /// </summary>
        private int GetAtRiskPatientCount()
        {
            try
            {
                int highRiskCount = 0;
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.DataBoundItem is Patient patient)
                    {
                        if (patient.MedicalUrgency == MedicalUrgency.High || patient.AttendanceRate < 60)
                        {
                            highRiskCount++;
                        }
                    }
                }
                return highRiskCount;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error getting at-risk patient count: " + ex.Message);
                return 0;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|Excel Files (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Selected file: " + openFileDialog.FileName);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}