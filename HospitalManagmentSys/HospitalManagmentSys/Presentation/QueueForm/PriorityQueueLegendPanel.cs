using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    /// <summary>Explains priority score bands at the bottom of the queue screen.</summary>
    public sealed class PriorityQueueLegendPanel : Panel
    {
        private const int CornerRadius = 8;

        public PriorityQueueLegendPanel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            BackColor = QueueTheme.Background;
            BorderStyle = BorderStyle.None;
            Height = 136;
            Padding = new Padding(18, 12, 18, 14);

            var lblHeader = new Label
            {
                Text = "How Priority Queue Works",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = QueueTheme.TextPrimary,
                AutoSize = true,
                Dock = DockStyle.Top,
                Margin = new Padding(0, 0, 0, 10)
            };

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                Margin = new Padding(0),
                BackColor = QueueTheme.Background
            };
            for (int i = 0; i < 4; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            table.Controls.Add(MakeItem(QueueTheme.EmergencyRed, "Emergency (8)", "Immediate attention, bypasses queue"), 0, 0);
            table.Controls.Add(MakeItem(QueueTheme.EmergencyRed, "High (6)", "Urgent care needed"), 1, 0);
            table.Controls.Add(MakeItem(QueueTheme.AccentGold, "Medium (4)", "Standard priority"), 2, 0);
            table.Controls.Add(MakeItem(QueueTheme.PriorityLowGreen, "Low (2)", "Routine checkups"), 3, 0);

            Controls.Add(table);
            Controls.Add(lblHeader);
        }

        private static Control MakeItem(Color dotColor, string title, string description)
        {
            var host = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(2, 0, 10, 0),
                BackColor = QueueTheme.Background
            };

            var inner = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Top,
                AutoSize = true,
                BackColor = QueueTheme.Background
            };
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            var dot = new LegendDotPanel(dotColor)
            {
                Size = new Size(16, 16),
                Margin = new Padding(0, 3, 0, 0),
                BackColor = QueueTheme.Background
            };

            var textStack = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                WrapContents = false,
                BackColor = QueueTheme.Background,
                Margin = new Padding(8, 0, 0, 0)
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = QueueTheme.TextPrimary,
                AutoSize = true,
                BackColor = QueueTheme.Background
            };

            var lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = QueueTheme.TextSecondary,
                AutoSize = true,
                MaximumSize = new Size(210, 0),
                BackColor = QueueTheme.Background
            };

            textStack.Controls.Add(lblTitle);
            textStack.Controls.Add(lblDesc);
            inner.Controls.Add(dot, 0, 0);
            inner.Controls.Add(textStack, 1, 0);
            host.Controls.Add(inner);
            return host;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = ClientRectangle;
            rect.Width--;
            rect.Height--;
            using var path = RoundedRectangle(rect, CornerRadius);
            using (var fill = new SolidBrush(BackColor))
                e.Graphics.FillPath(fill, path);
            using var border = new Pen(QueueTheme.BorderSubtle);
            e.Graphics.DrawPath(border, path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using var path = RoundedRectangle(ClientRectangle, CornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
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

        private sealed class LegendDotPanel : Panel
        {
            private readonly Color _dotColor;

            public LegendDotPanel(Color dotColor)
            {
                _dotColor = dotColor;
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var r = ClientRectangle;
                r.Inflate(-1, -1);
                using var b = new SolidBrush(_dotColor);
                e.Graphics.FillEllipse(b, r);
            }
        }
    }
}
