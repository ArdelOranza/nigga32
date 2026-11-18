using System.Drawing;

namespace IM_FINAL_REQ
{
    public static class Theme
    {
        // Brand Colors
        public static readonly Color PSU_Blue = Color.FromArgb(10, 49, 132);
        public static readonly Color PSU_Gold = Color.FromArgb(218, 165, 32); // Slightly darker, more professional gold

        // Enterprise UI Palette
        public static readonly Color BgSlate = Color.FromArgb(243, 244, 246); // Soft gray background
        public static readonly Color BgWhite = Color.White;
        public static readonly Color BorderGray = Color.FromArgb(209, 213, 219); // Crisp 1px borders
        public static readonly Color TextDark = Color.FromArgb(17, 24, 39); // Almost black
        public static readonly Color TextGray = Color.FromArgb(107, 114, 128);
        public static readonly Color RedAlert = Color.FromArgb(220, 38, 38);

        // Typography
        public static readonly Font TitleFont = new Font("Segoe UI", 28F, FontStyle.Bold);
        public static readonly Font HeaderFont = new Font("Segoe UI", 20F, FontStyle.Bold);
        public static readonly Font SubFont = new Font("Segoe UI", 12F);
        public static readonly Font BtnFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font MonoFont = new Font("Consolas", 72F, FontStyle.Bold);
    }
}