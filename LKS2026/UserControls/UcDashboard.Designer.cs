using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle, lblSubtitle;
        private Button btnRefresh;
        private FlowLayoutPanel flowCards;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = UiTheme.ContentBg;

            pnlHeader = new Panel { Dock = DockStyle.Top, Height = 80 };
            lblTitle = new Label
            {
                Text = "Ringkasan Sistem",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(0, 0)
            };
            lblSubtitle = new Label
            {
                Text = "Statistik data operasional SPPG.",
                Font = UiTheme.FontNormal,
                ForeColor = UiTheme.Muted,
                AutoSize = true,
                Location = new Point(0, 30)
            };
            btnRefresh = UiHelper.MakeActionButton("⟳ Refresh", UiTheme.Primary, BtnRefresh_Click);
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // posisi kanan di onload
            pnlHeader.Resize += (s, e) => { btnRefresh.Left = pnlHeader.Width - btnRefresh.Width - 4; };
            btnRefresh.Top = 10;

            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle, btnRefresh });

            flowCards = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = UiTheme.ContentBg,
                Padding = new Padding(0, 10, 0, 0)
            };

            this.Controls.Add(flowCards);
            this.Controls.Add(pnlHeader);
            this.ResumeLayout(false);
        }
    }
}
