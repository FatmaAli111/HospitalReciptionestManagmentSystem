using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    /// <summary>Flat stat card with 1px border and rounded corners.</summary>
    public sealed class StatCardPanel : Panel
    {
        private const int DefaultCornerRadius = 8;

        public StatCardPanel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            BackColor = QueueTheme.Background;
            BorderStyle = BorderStyle.None;
            Padding = new Padding(16, 14, 16, 14);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = ClientRectangle;
            rect.Width--;
            rect.Height--;
            using var path = RoundedRectangle(rect, DefaultCornerRadius);
            using (var fill = new SolidBrush(BackColor))
                e.Graphics.FillPath(fill, path);
            using var border = new Pen(QueueTheme.BorderSubtle);
            e.Graphics.DrawPath(border, path);
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            using var path = RoundedRectangle(ClientRectangle, DefaultCornerRadius);
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
    }
}
