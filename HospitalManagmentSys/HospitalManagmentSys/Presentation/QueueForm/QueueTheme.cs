using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    /// <summary>Central palette and typography for the queue management screen.</summary>
    public static class QueueTheme
    {
        public static readonly Color Background = Color.FromArgb(255, 255, 255);
        public static readonly Color SurfaceMuted = Color.FromArgb(248, 249, 250);
        public static readonly Color BorderSubtle = Color.FromArgb(224, 224, 224);

        public static readonly Color PrimaryBlue = Color.FromArgb(0, 86, 179);
        public static readonly Color EmergencyRed = Color.FromArgb(211, 47, 47);
        public static readonly Color AccentGold = Color.FromArgb(251, 192, 45);
        public static readonly Color UrgencyOrange = Color.FromArgb(255, 152, 0);
        public static readonly Color PriorityLowGreen = Color.FromArgb(56, 142, 60);

        public static readonly Color TextPrimary = Color.FromArgb(30, 30, 30);
        public static readonly Color TextSecondary = Color.FromArgb(120, 120, 120);
        public static readonly Color TextMuted = Color.FromArgb(150, 150, 150);

        public static readonly Color AvatarBackground = Color.FromArgb(227, 242, 253);
        public static readonly Color RankSecondaryBack = Color.FromArgb(224, 224, 224);
        public static readonly Color RankSecondaryFore = Color.FromArgb(80, 80, 80);

        public const string Mdl2FontFamily = "Segoe MDL2 Assets";

        public static Font Mdl2Font(float sizeInPoints = 18f) =>
            new(Mdl2FontFamily, sizeInPoints, FontStyle.Regular, GraphicsUnit.Point);

        public static Font TitleFont => new("Segoe UI", 22f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font HeaderSubtitleFont => new("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point);
        public static Font StatValueFont => new("Segoe UI", 22f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font StatCaptionFont => new("Segoe UI", 9.5f, FontStyle.Regular, GraphicsUnit.Point);
        public static Font SectionTitleFont => new("Segoe UI", 14f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font SectionSubtitleFont => new("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);

        public static void ApplyFlatButton(Button b, Color back, Color fore)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = back;
            b.ForeColor = fore;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }
    }
}
