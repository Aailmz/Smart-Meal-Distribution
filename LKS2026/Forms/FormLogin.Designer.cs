using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLeft;
        private Panel pnlRight;
        private Label lblBrand;
        private Label lblTagline;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBatal;
        private Label lblError;
        private Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // === Form ===
            this.Text = "Login - Smart Meal Distribution System";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(820, 460);
            this.BackColor = Color.White;

            // === Left brand panel ===
            pnlLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = 360,
                BackColor = UiTheme.Primary
            };
            lblBrand = new Label
            {
                Text = "SPPG",
                Font = new Font("Segoe UI", 36F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 90)
            };
            lblTagline = new Label
            {
                Text = "Smart Meal\nDistribution System",
                Font = new Font("Segoe UI", 16F, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 170)
            };
            var lblFoot = new Label
            {
                Text = "LKS SMK Jawa Barat 2026\nIT Software Solution for Business",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(220, 235, 255),
                AutoSize = true,
                Location = new Point(40, 380)
            };
            pnlLeft.Controls.AddRange(new Control[] { lblBrand, lblTagline, lblFoot });

            // === Right login panel ===
            pnlRight = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(50, 40, 50, 40)
            };

            lblTitle = new Label
            {
                Text = "Masuk ke Sistem",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 37, 41),
                AutoSize = true,
                Location = new Point(50, 50)
            };
            lblSubtitle = new Label
            {
                Text = "Silakan masuk dengan akun Anda untuk melanjutkan.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = UiTheme.Muted,
                AutoSize = true,
                Location = new Point(50, 92)
            };

            lblUser = new Label
            {
                Text = "Username",
                Font = UiTheme.FontBold,
                AutoSize = true,
                Location = new Point(50, 140)
            };
            txtUsername = new TextBox
            {
                Location = new Point(50, 165),
                Size = new Size(360, 28),
                Font = UiTheme.FontNormal,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblPass = new Label
            {
                Text = "Password",
                Font = UiTheme.FontBold,
                AutoSize = true,
                Location = new Point(50, 205)
            };
            txtPassword = new TextBox
            {
                Location = new Point(50, 230),
                Size = new Size(360, 28),
                Font = UiTheme.FontNormal,
                BorderStyle = BorderStyle.FixedSingle,
                UseSystemPasswordChar = true
            };
            txtPassword.KeyDown += TxtPassword_KeyDown;

            lblError = new Label
            {
                Text = "",
                Visible = false,
                ForeColor = UiTheme.Danger,
                Font = UiTheme.FontNormal,
                AutoSize = false,
                Size = new Size(360, 20),
                Location = new Point(50, 265)
            };

            btnLogin = new Button
            {
                Text = "MASUK",
                Location = new Point(50, 295),
                Size = new Size(240, 42),
                BackColor = UiTheme.Primary,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;

            btnBatal = new Button
            {
                Text = "Batal",
                Location = new Point(298, 295),
                Size = new Size(112, 42),
                BackColor = Color.White,
                ForeColor = UiTheme.Muted,
                Font = UiTheme.FontNormal,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnBatal.FlatAppearance.BorderColor = UiTheme.Muted;
            btnBatal.Click += BtnBatal_Click;

            lblHint = new Label
            {
                Text = "Akun default:\n  petugas / petugas123\n  supervisor / supervisor123",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = UiTheme.Muted,
                AutoSize = true,
                Location = new Point(50, 360)
            };

            pnlRight.Controls.AddRange(new Control[] {
                lblTitle, lblSubtitle, lblUser, txtUsername,
                lblPass, txtPassword, lblError, btnLogin, btnBatal, lblHint
            });

            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);
            this.AcceptButton = btnLogin;
            this.ResumeLayout(false);
        }
    }
}
