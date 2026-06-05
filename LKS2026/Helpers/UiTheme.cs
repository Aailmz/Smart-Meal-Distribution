using System.Drawing;

namespace LKS2026.Helpers
{
    /// <summary>Palet warna konsisten untuk seluruh aplikasi.</summary>
    public static class UiTheme
    {
        public static readonly Color Primary       = Color.FromArgb(0, 120, 215);   // biru utama
        public static readonly Color PrimaryDark   = Color.FromArgb(0, 90, 158);
        public static readonly Color SidebarBg     = Color.FromArgb(33, 37, 41);    // gelap
        public static readonly Color SidebarItem   = Color.FromArgb(52, 58, 64);
        public static readonly Color SidebarActive = Color.FromArgb(0, 120, 215);
        public static readonly Color SidebarText   = Color.White;
        public static readonly Color HeaderBg      = Color.FromArgb(248, 249, 250);
        public static readonly Color ContentBg     = Color.White;
        public static readonly Color CardBg        = Color.White;

        public static readonly Color Success = Color.FromArgb(40, 167, 69);
        public static readonly Color Warning = Color.FromArgb(255, 193, 7);
        public static readonly Color Info    = Color.FromArgb(23, 162, 184);
        public static readonly Color Danger  = Color.FromArgb(220, 53, 69);
        public static readonly Color Muted   = Color.FromArgb(108, 117, 125);

        public static readonly Font FontTitle   = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontSubtitle= new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font FontNormal  = new Font("Segoe UI", 10F);
        public static readonly Font FontBold    = new Font("Segoe UI", 10F, FontStyle.Bold);

        /// <summary>Warna badge untuk status pesanan/produksi/distribusi.</summary>
        public static Color StatusColor(string status)
        {
            if (string.IsNullOrEmpty(status)) return Muted;
            switch (status.Trim().ToLowerInvariant())
            {
                case "pending":
                case "belum diproses":
                case "belum dikirim":
                    return Warning;
                case "diproses":
                case "dikirim":
                    return Info;
                case "selesai":
                    return Success;
                default:
                    return Muted;
            }
        }
    }
}
