
using Guna.UI2.WinForms;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Presentation.Dashbord;
using Guna.UI2.WinForms;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Presentation.Dashbord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class systenm : UserControl
    {
        private DoctorsListsection doctorsListSection;
        private Panel secondTablePanel;
        private Panel mainContainer; 

        public systenm()
        {
            InitializeComponent();
            SetupFormScroll(); 
            AddSecondTable();
        }

        private void SetupFormScroll()
        {
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(this.Width, 800); 

            mainContainer = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(this.ClientSize.Width - 20, 1200),
                BackColor = Color.Transparent
            };

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != mainContainer)
                {
                    this.Controls.Remove(ctrl);
                    mainContainer.Controls.Add(ctrl);
                }
            }

            this.Controls.Add(mainContainer);
        }

        private void AddSecondTable()
        {
            int secondTableTop = guna2CustomGradientPanel1.Bottom + 20;

            secondTablePanel = new Panel
            {
                Location = new Point(guna2CustomGradientPanel1.Left, secondTableTop),
                Size = guna2CustomGradientPanel1.Size,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label secondTableTitle = new Label
            {
                Text = "Doctors Availability",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(22, 18),
                AutoSize = true,
                BackColor = Color.White
            };

            Label secondTableSubtitle = new Label
            {
                Text = "Manage doctors and their availability",
                Font = new Font("Segoe UI", 11.25F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(22, 53),
                AutoSize = true,
                BackColor = Color.White
            };

            doctorsListSection = new DoctorsListsection();
            doctorsListSection.Location = new Point(22, 85);
            doctorsListSection.Width = secondTablePanel.Width;
            doctorsListSection.Height = secondTablePanel.Height - 110;
            doctorsListSection.BackColor = Color.White;

            secondTablePanel.Controls.Add(secondTableTitle);
            secondTablePanel.Controls.Add(secondTableSubtitle);
            secondTablePanel.Controls.Add(doctorsListSection);

            mainContainer.Controls.Add(secondTablePanel);

            UpdateMainContainerHeight();
        }

        private void UpdateMainContainerHeight()
        {
            if (mainContainer != null)
            {
                int totalHeight = 0;
                foreach (Control ctrl in mainContainer.Controls)
                {
                    totalHeight = Math.Max(totalHeight, ctrl.Bottom + 50);
                }
                mainContainer.Height = Math.Max(totalHeight, this.ClientSize.Height);
            }
        }

        private void system_Load(object sender, EventArgs e)
        {
            UpdateMainContainerHeight();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (mainContainer != null)
            {
                mainContainer.Width = this.ClientSize.Width - 20;

                if (secondTablePanel != null && guna2CustomGradientPanel1 != null)
                {
                    secondTablePanel.Location = new Point(guna2CustomGradientPanel1.Left, guna2CustomGradientPanel1.Bottom + 20);
                    secondTablePanel.Size = guna2CustomGradientPanel1.Size;

                    if (doctorsListSection != null)
                    {
                        doctorsListSection.Width = secondTablePanel.Width - 44;
                        doctorsListSection.Height = secondTablePanel.Height - 110;
                    }
                }

                UpdateMainContainerHeight();
            }
        }
    }

    // ==================== DoctorsListSection ====================
    public class DoctorsListsection : FlowLayoutPanel
    {
        public DoctorsListsection()
        {
            this.AutoSize = false;
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoScroll = true;
            this.BackColor = Color.White;
            LoadData();
        }

        private void LoadData()
        {
            this.Controls.Clear();

            try
            {
                DashbordServices dashbordServices = new DashbordServices();
                var doctors = dashbordServices.DoctorsAvailable();

                if (doctors == null || !doctors.Any())
                {
                    Label noDataLabel = new Label
                    {
                        Text = "No doctors available",
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(10)
                    };
                    this.Controls.Add(noDataLabel);
                    return;
                }

                foreach (var n in doctors)
                {
                    if (n.Doctor == null) continue;

                    DoctorCardControl doc = new DoctorCardControl();
                    doc.Width = this.Width;
                    doc.Margin = new Padding(5, 5, 5, 5);

                    if (doc.Controls["DocName"] is Label lblName)
                        lblName.Text = n.Name ?? "Unknown";

                    if (doc.Controls["specialty"] is Label lblSpec)
                        lblSpec.Text = n.Doctor.Specialty ?? "Not specified";

                    if (doc.Controls["btnAvatar"] is Guna2CircleButton avar)
                        avar.Text = GetFirstCharacter(n.Name);

                    this.Controls.Add(doc);
                }
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label
                {
                    Text = $"Error loading doctors: {ex.Message}",
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Padding = new Padding(10)
                };
                this.Controls.Add(errorLabel);
            }
        }

        private string GetFirstCharacter(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "?";

            return name.Trim().Substring(0, 1).ToUpper();
        }
    }
}