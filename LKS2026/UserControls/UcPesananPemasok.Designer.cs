using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcPesananPemasok
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle, lblCari;
        private TextBox txtCari;
        private Button btnTambah, btnUbah, btnHapus, btnStatus;
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
            lblTitle = new Label { Text = "Pesanan ke Pemasok", Font = new Font("Segoe UI", 14F, FontStyle.Bold), AutoSize = true, Location = new Point(0, 0) };
            lblCari = new Label { Text = "Cari (pemasok / bahan / status):", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(0, 50) };
            txtCari = UiHelper.MakeTextBox(220); txtCari.Location = new Point(210, 47); txtCari.TextChanged += TxtCari_TextChanged;
            btnTambah = UiHelper.MakeActionButton("+ Tambah", UiTheme.Success, BtnTambah_Click); btnTambah.Location = new Point(460, 42);
            btnUbah   = UiHelper.MakeActionButton("Ubah",     UiTheme.Primary, BtnUbah_Click);   btnUbah.Location   = new Point(575, 42);
            btnHapus  = UiHelper.MakeActionButton("Hapus",    UiTheme.Danger,  BtnHapus_Click);  btnHapus.Location  = new Point(690, 42);
            btnStatus = UiHelper.MakeActionButton("Ubah Status", UiTheme.Info, BtnStatus_Click); btnStatus.Location = new Point(805, 42); btnStatus.Width = 130;
            pnlTop.Controls.AddRange(new Control[] { lblTitle, lblCari, txtCari, btnTambah, btnUbah, btnHapus, btnStatus });

            grid = new DataGridView { Dock = DockStyle.Fill };
            UiHelper.StyleGrid(grid);
            grid.CellFormatting += Grid_CellFormatting;

            this.Controls.Add(grid);
            this.Controls.Add(pnlTop);
            this.ResumeLayout(false);
        }
    }
}
