using System.Drawing.Drawing2D;

namespace HospitalManagmentSys.Presentation
{
    public partial class PatientQueueItem : UserControl
    {
        private int _progressPercent;
        private Color _progressColor = QueueTheme.EmergencyRed;
        private bool _rankPrimary = true;

        public event EventHandler? StartClicked;
        public event EventHandler? NoShowClicked;

        public PatientQueueItem()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            QueueTheme.ApplyFlatButton(btnStart, QueueTheme.PrimaryBlue, Color.White);
            QueueTheme.ApplyFlatButton(btnNoShow, QueueTheme.EmergencyRed, Color.White);

            pnlRank.Paint += OnRankPaint;
            pnlAvatar.Paint += OnAvatarPaint;
            pnlProgressTrack.Paint += OnProgressPaint;
            pnlTopRow.Resize += (_, _) => LayoutTopRow();
            Resize += (_, _) => LayoutTopRow();

        }

        public void SetPatientData(
            int position,
            string patientName,
            string initials,
            string doctor,
            string department,
            string scheduledTime,
            TimeSpan? waitingDuration,
            int priorityScore,
            string priority,
            string symptom)
        {
            _rankPrimary = position <= 1;
            lblRank.Text = position.ToString();
            lblRank.ForeColor = _rankPrimary ? Color.White : QueueTheme.RankSecondaryFore;
            lblInitials.Text = initials;
            lblPatientName.Text = patientName;
            lblDoctorDept.Text = $"Dr. {doctor} • {department}";
            lblScheduled.Text = $"Scheduled: {scheduledTime}";
            lblWaiting.Text = $"Waiting: {FormatWaiting(waitingDuration)}";
            lblScore.Text = $"Score: {priorityScore}";
            lblSymptom.Text = symptom;

            int score = Math.Clamp(priorityScore, 0, 100);
            _progressPercent = score;
            pnlUrgencyBar.BackColor = UrgencyColor(score);
            _progressColor = UrgencyColor(score);

            bool high = string.Equals(priority, "HIGH", StringComparison.OrdinalIgnoreCase);
            lblPriorityBadge.Text = high ? "HIGH" : "MEDIUM";
            lblPriorityBadge.BackColor = high ? QueueTheme.EmergencyRed : QueueTheme.AccentGold;
            lblPriorityBadge.ForeColor = high ? Color.White : QueueTheme.TextPrimary;
            lblPriorityBadge.Region = RoundedRegion(lblPriorityBadge.ClientRectangle, 6);

            pnlRank.Invalidate();
            pnlAvatar.Invalidate();
            pnlProgressTrack.Invalidate();
            LayoutTopRow();
        }

        private static string FormatWaiting(TimeSpan? duration)
        {
            if (duration is null)
                return "--";

            var t = duration.Value;
            if (t < TimeSpan.Zero)
                return "--";

            int h = (int)Math.Floor(t.TotalHours);
            int m = t.Minutes;
            if (h == 0 && m == 0 && t.TotalSeconds < 60)
                return "< 1m";

            return $"{h}h {m}m";
        }

        private static Color UrgencyColor(int score)
        {
            if (score > 80)
                return QueueTheme.EmergencyRed;
            if (score >= 50)
                return QueueTheme.UrgencyOrange;
            return QueueTheme.AccentGold;
        }

        private void LayoutTopRow()
        {
            if (pnlTopRow.Width <= 0)
                return;

            const int actionsWidth = 216;
            int x = Math.Max(0, pnlTopRow.Width - actionsWidth - 4);
            pnlActions.Left = x;
            pnlActions.Width = actionsWidth;

            int centerRight = x - 10;
            int centerWidth = centerRight - pnlCenter.Left;
            pnlCenter.Width = Math.Max(160, centerWidth);
        }

        private void OnRankPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = pnlRank.ClientRectangle;
            rect.Inflate(-1, -1);
            using var brush = new SolidBrush(_rankPrimary ? QueueTheme.PrimaryBlue : QueueTheme.RankSecondaryBack);
            g.FillEllipse(brush, rect);
            using var pen = new Pen(_rankPrimary ? QueueTheme.PrimaryBlue : QueueTheme.BorderSubtle);
            g.DrawEllipse(pen, rect);
        }

        private void OnAvatarPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = pnlAvatar.ClientRectangle;
            rect.Inflate(-1, -1);
            using var brush = new SolidBrush(QueueTheme.AvatarBackground);
            g.FillEllipse(brush, rect);
            using var pen = new Pen(QueueTheme.BorderSubtle);
            g.DrawEllipse(pen, rect);
        }

        private void OnProgressPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = pnlProgressTrack.ClientRectangle;
            using (var track = new SolidBrush(Color.FromArgb(236, 236, 236)))
                g.FillRectangle(track, rect);

            int fillW = (int)(rect.Width * (_progressPercent / 100f));
            if (fillW > 0)
            {
                using var fill = new SolidBrush(_progressColor);
                g.FillRectangle(fill, 0, 0, fillW, rect.Height);
            }
        }

        private static Region RoundedRegion(Rectangle bounds, int radius)
        {
            using var path = RoundedRectPath(bounds, radius);
            return new Region(path);
        }

        private static GraphicsPath RoundedRectPath(Rectangle bounds, int radius)
        {
            int d = Math.Max(0, Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height)));
            var path = new GraphicsPath();
            if (d <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            var arc = new Rectangle(bounds.Location, new Size(d, d));
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - d;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - d;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void BtnStart_Click(object? sender, EventArgs e) => StartClicked?.Invoke(this, e);

        private void BtnNoShow_Click(object? sender, EventArgs e) => NoShowClicked?.Invoke(this, e);
    }
}
