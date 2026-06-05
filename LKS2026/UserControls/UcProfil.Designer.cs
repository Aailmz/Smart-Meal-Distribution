using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcProfil
    {
        private System.ComponentModel.IContainer components = null;
        private Panel card;
        private Label lblTitle;
        private Label lblUsernameVal;
        private Label lblFullNameVal;
        private Label lblRoleVal;
        private Label lblPositionVal;
        private Label avatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = UiTheme.ContentBg;

            card = new Panel
            {
                Size = new Size(560, 380),
                BackColor = Color.White,
                Location = new Point(40, 30)
            };
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(225, 225, 225)))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            };

            // Header bar
            var hdr = new Panel { Dock = DockStyle.Top, Height = 90, BackColor = UiTheme.Primary };
            avatar = new Label
            {
                Text = "👤",
                Font = new Font("Segoe UI Emoji", 32F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(64, 64),
                Location = new Point(20, 13)
            };
            lblTitle = new Label
            {
                Text = "Profil Pengguna",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(100, 35)
            };
            hdr.Controls.Add(avatar);
            hdr.Controls.Add(lblTitle);
            card.Controls.Add(hdr);

            int xL = 40, xR = 200, y = 120;
            void Row(string label, ref Label valTarget)
            {
                var l1 = new Label { Text = label, Font = UiTheme.FontBold, AutoSize = true, Location = new Point(xL, y), ForeColor = UiTheme.Muted };
                valTarget = new Label { Text = "-", Font = new Font("Segoe UI", 11F, FontStyle.Regular), AutoSize = true, Location = new Point(xR, y) };
                card.Controls.Add(l1);
                card.Controls.Add(valTarget);
                y += 50;
            }

            Row("Username",     ref lblUsernameVal);
            Row("Nama Lengkap", ref lblFullNameVal);
            Row("Role",         ref lblRoleVal);
            Row("Jabatan",      ref lblPositionVal);

            this.Controls.Add(card);
            this.ResumeLayout(false);
        }
    }
}
