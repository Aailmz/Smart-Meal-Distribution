using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    partial class UcMonitoring
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle, lblFilter, lblAwal, lblAkhir, lblStatus;
        private DateTimePicker dtAwal, dtAkhir;
        private ComboBox cmbFilterStatus;
        private Button btnFilter, btnReset;
        private Button btnTambah, btnUbah, btnHapus, btnStatusProd, btnStatusDist;
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

            pnlTop = new Panel { Dock = DockStyle.Top, Height = 150 };

            lblTitle = new Label { Text = "Monitoring Produksi & Distribusi", Font = new Font("Segoe UI", 14F, FontStyle.Bold), AutoSize = true, Location = new Point(0, 0) };

            // Filter row
            lblFilter = new Label { Text = "Filter:", Font = UiTheme.FontBold, AutoSize = true, Location = new Point(0, 45) };
            lblAwal   = new Label { Text = "Dari", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(60, 47) };
            dtAwal    = new DateTimePicker { Font = UiTheme.FontNormal, Format = DateTimePickerFormat.Short, ShowCheckBox = true, Checked = false, Location = new Point(95, 43), Width = 130 };
            lblAkhir  = new Label { Text = "s/d", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(235, 47) };
            dtAkhir   = new DateTimePicker { Font = UiTheme.FontNormal, Format = DateTimePickerFormat.Short, ShowCheckBox = true, Checked = false, Location = new Point(265, 43), Width = 130 };
            lblStatus = new Label { Text = "Status", Font = UiTheme.FontNormal, AutoSize = true, Location = new Point(405, 47) };
            cmbFilterStatus = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Font = UiTheme.FontNormal, Location = new Point(450, 43), Width = 130 };
            cmbFilterStatus.Items.AddRange(new object[] { "(semua)", "Belum Diproses", "Diproses", "Belum Dikirim", "Dikirim", "Selesai" });
            cmbFilterStatus.SelectedIndex = 0;
            btnFilter = UiHelper.MakeActionButton("Terapkan", UiTheme.Primary, BtnFilter_Click); btnFilter.Size = new Size(90, 32); btnFilter.Location = new Point(595, 43);
            btnReset  = UiHelper.MakeActionButton("Reset",    UiTheme.Muted,   BtnReset_Click);  btnReset.Size  = new Size(70, 32); btnReset.Location  = new Point(690, 43);

            // Action row
            btnTambah = UiHelper.MakeActionButton("+ Tambah", UiTheme.Success, BtnTambah_Click); btnTambah.Location = new Point(0, 100);
            btnUbah   = UiHelper.MakeActionButton("Ubah",     UiTheme.Primary, BtnUbah_Click);   btnUbah.Location   = new Point(115, 100);
            btnHapus  = UiHelper.MakeActionButton("Hapus",    UiTheme.Danger,  BtnHapus_Click);  btnHapus.Location  = new Point(230, 100);
            btnStatusProd = UiHelper.MakeActionButton("Status Produksi",  UiTheme.Info, BtnStatusProd_Click); btnStatusProd.Size = new Size(150, 36); btnStatusProd.Location = new Point(360, 100);
            btnStatusDist = UiHelper.MakeActionButton("Status Distribusi", UiTheme.Info, BtnStatusDist_Click); btnStatusDist.Size = new Size(160, 36); btnStatusDist.Location = new Point(520, 100);

            pnlTop.Controls.AddRange(new Control[] {
                lblTitle, lblFilter, lblAwal, dtAwal, lblAkhir, dtAkhir, lblStatus, cmbFilterStatus, btnFilter, btnReset,
                btnTambah, btnUbah, btnHapus, btnStatusProd, btnStatusDist
            });

            grid = new DataGridView { Dock = DockStyle.Fill };
            UiHelper.StyleGrid(grid);
            grid.CellFormatting += Grid_CellFormatting;

            this.Controls.Add(grid);
            this.Controls.Add(pnlTop);
            this.ResumeLayout(false);
        }
    }
}
