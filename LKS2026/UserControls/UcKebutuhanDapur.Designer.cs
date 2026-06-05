using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcKebutuhanDapur
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle, lblCari;
        private TextBox txtCari;
        private Button btnTambah, btnUbah, btnHapus;
        private DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = UiTheme.ContentBg;

            pnlTop = new Panel { Dock = DockStyle.Top, Height = 90 };
            lblTitle = new Label { Text = "Kebutuhan Dapur SPPG", Font = new Font("Segoe UI", 14F, FontStyle.Bold), AutoSize = true, Location = new Point(0, 0) };
            lblCari = new Label { Text = "Cari (bahan / tanggal yyyy-mm-dd):", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(0, 50) };
            txtCari = UiHelper.MakeTextBox(220); txtCari.Location = new Point(220, 47); txtCari.TextChanged += TxtCari_TextChanged;
            btnTambah = UiHelper.MakeActionButton("+ Tambah", UiTheme.Success, BtnTambah_Click); btnTambah.Location = new Point(470, 42);
            btnUbah   = UiHelper.MakeActionButton("Ubah",     UiTheme.Primary, BtnUbah_Click);   btnUbah.Location   = new Point(585, 42);
            btnHapus  = UiHelper.MakeActionButton("Hapus",    UiTheme.Danger,  BtnHapus_Click);  btnHapus.Location  = new Point(700, 42);
            pnlTop.Controls.AddRange(new Control[] { lblTitle, lblCari, txtCari, btnTambah, btnUbah, btnHapus });

            grid = new DataGridView { Dock = DockStyle.Fill };
            UiHelper.StyleGrid(grid);

            this.Controls.Add(grid);
            this.Controls.Add(pnlTop);
            this.ResumeLayout(false);
        }
    }
}
