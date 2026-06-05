using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSidebar;
        private Panel pnlSidebarHeader;
        private Panel pnlSidebarMenu;
        private Panel pnlSidebarFooter;
        private Label lblBrand;
        private Label lblBrandSub;
        private Button btnLogout;

        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label lblUser;
        private Label lblRole;
        private Panel pnlContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "SPPG - Smart Meal Distribution System";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1100, 680);
            this.BackColor = UiTheme.ContentBg;

            // ===== Sidebar =====
            pnlSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 240,
                BackColor = UiTheme.SidebarBg
            };

            pnlSidebarHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 92,
                BackColor = UiTheme.PrimaryDark
            };
            lblBrand = new Label
            {
                Text = "SPPG",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 14)
            };
            lblBrandSub = new Label
            {
                Text = "Smart Meal Distribution",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(200, 220, 240),
                AutoSize = true,
                Location = new Point(22, 56)
            };
            pnlSidebarHeader.Controls.AddRange(new Control[] { lblBrand, lblBrandSub });

            pnlSidebarFooter = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = UiTheme.SidebarBg,
                Padding = new Padding(12, 8, 12, 12)
            };
            btnLogout = new Button
            {
                Text = "  Logout",
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Danger,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Click += BtnLogout_Click;
            pnlSidebarFooter.Controls.Add(btnLogout);

            pnlSidebarMenu = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.SidebarBg,
                AutoScroll = true
            };

            pnlSidebar.Controls.Add(pnlSidebarMenu);
            pnlSidebar.Controls.Add(pnlSidebarFooter);
            pnlSidebar.Controls.Add(pnlSidebarHeader);

            // ===== Header bar =====
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = UiTheme.HeaderBg,
                Padding = new Padding(24, 0, 24, 0)
            };
            lblPageTitle = new Label
            {
                Text = "Dashboard",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 37, 41),
                AutoSize = false,
                Dock = DockStyle.Left,
                Width = 600,
                TextAlign = ContentAlignment.MiddleLeft
            };
            lblUser = new Label
            {
                Text = "User",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 37, 41),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Right,
                Width = 220,
                Padding = new Padding(0, 12, 0, 0)
            };
            lblRole = new Label
            {
                Text = "Role",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = UiTheme.Muted,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Right,
                Width = 220,
                Padding = new Padding(0, 38, 0, 0)
            };
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblUser);
            pnlHeader.Controls.Add(lblPageTitle);

            // ===== Content =====
            pnlContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.ContentBg,
                Padding = new Padding(20)
            };

            // Order: Content (fill) -> Header (top) -> Sidebar (left)
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSidebar);

            this.ResumeLayout(false);
        }
    }
}
