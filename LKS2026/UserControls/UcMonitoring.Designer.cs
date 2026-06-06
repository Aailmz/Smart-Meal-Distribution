namespace LKS2026.UserControls
{
    partial class UcMonitoring
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblAwal;
        private System.Windows.Forms.Label lblAkhir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtAwal;
        private System.Windows.Forms.DateTimePicker dtAkhir;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnStatusProd;
        private System.Windows.Forms.Button btnStatusDist;
        private System.Windows.Forms.DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblAwal = new System.Windows.Forms.Label();
            this.lblAkhir = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtAwal = new System.Windows.Forms.DateTimePicker();
            this.dtAkhir = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnStatusProd = new System.Windows.Forms.Button();
            this.btnStatusDist = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Controls.Add(this.lblAwal);
            this.pnlTop.Controls.Add(this.dtAwal);
            this.pnlTop.Controls.Add(this.lblAkhir);
            this.pnlTop.Controls.Add(this.dtAkhir);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.cmbFilterStatus);
            this.pnlTop.Controls.Add(this.btnFilter);
            this.pnlTop.Controls.Add(this.btnReset);
            this.pnlTop.Controls.Add(this.btnTambah);
            this.pnlTop.Controls.Add(this.btnUbah);
            this.pnlTop.Controls.Add(this.btnHapus);
            this.pnlTop.Controls.Add(this.btnStatusProd);
            this.pnlTop.Controls.Add(this.btnStatusDist);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 150);
            this.pnlTop.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Monitoring Produksi & Distribusi";
            //
            // lblFilter
            //
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(0, 45);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(50, 19);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter:";
            //
            // lblAwal
            //
            this.lblAwal.AutoSize = true;
            this.lblAwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAwal.Location = new System.Drawing.Point(60, 47);
            this.lblAwal.Name = "lblAwal";
            this.lblAwal.Size = new System.Drawing.Size(33, 19);
            this.lblAwal.TabIndex = 2;
            this.lblAwal.Text = "Dari";
            //
            // dtAwal
            //
            this.dtAwal.Checked = false;
            this.dtAwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAwal.Location = new System.Drawing.Point(95, 43);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.ShowCheckBox = true;
            this.dtAwal.Size = new System.Drawing.Size(130, 25);
            this.dtAwal.TabIndex = 3;
            //
            // lblAkhir
            //
            this.lblAkhir.AutoSize = true;
            this.lblAkhir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAkhir.Location = new System.Drawing.Point(235, 47);
            this.lblAkhir.Name = "lblAkhir";
            this.lblAkhir.Size = new System.Drawing.Size(28, 19);
            this.lblAkhir.TabIndex = 4;
            this.lblAkhir.Text = "s/d";
            //
            // dtAkhir
            //
            this.dtAkhir.Checked = false;
            this.dtAkhir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAkhir.Location = new System.Drawing.Point(265, 43);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.ShowCheckBox = true;
            this.dtAkhir.Size = new System.Drawing.Size(130, 25);
            this.dtAkhir.TabIndex = 5;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(405, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            //
            // cmbFilterStatus
            //
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "(semua)",
            "Belum Diproses",
            "Diproses",
            "Belum Dikirim",
            "Dikirim",
            "Selesai"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(450, 43);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbFilterStatus.TabIndex = 7;
            //
            // btnFilter
            //
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(595, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 32);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Terapkan";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            //
            // btnReset
            //
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(690, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 32);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            //
            // btnTambah
            //
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(0, 100);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(110, 36);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "+ Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            //
            // btnUbah
            //
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(115, 100);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 36);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            //
            // btnHapus
            //
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(230, 100);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 36);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            //
            // btnStatusProd
            //
            this.btnStatusProd.BackColor = System.Drawing.Color.FromArgb(23, 162, 184);
            this.btnStatusProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatusProd.FlatAppearance.BorderSize = 0;
            this.btnStatusProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusProd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatusProd.ForeColor = System.Drawing.Color.White;
            this.btnStatusProd.Location = new System.Drawing.Point(360, 100);
            this.btnStatusProd.Name = "btnStatusProd";
            this.btnStatusProd.Size = new System.Drawing.Size(150, 36);
            this.btnStatusProd.TabIndex = 13;
            this.btnStatusProd.Text = "Status Produksi";
            this.btnStatusProd.UseVisualStyleBackColor = false;
            this.btnStatusProd.Click += new System.EventHandler(this.BtnStatusProd_Click);
            //
            // btnStatusDist
            //
            this.btnStatusDist.BackColor = System.Drawing.Color.FromArgb(23, 162, 184);
            this.btnStatusDist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatusDist.FlatAppearance.BorderSize = 0;
            this.btnStatusDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusDist.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatusDist.ForeColor = System.Drawing.Color.White;
            this.btnStatusDist.Location = new System.Drawing.Point(520, 100);
            this.btnStatusDist.Name = "btnStatusDist";
            this.btnStatusDist.Size = new System.Drawing.Size(160, 36);
            this.btnStatusDist.TabIndex = 14;
            this.btnStatusDist.Text = "Status Distribusi";
            this.btnStatusDist.UseVisualStyleBackColor = false;
            this.btnStatusDist.Click += new System.EventHandler(this.BtnStatusDist_Click);
            //
            // grid
            //
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            altStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.grid.AlternatingRowsDefaultCellStyle = altStyle;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.grid.ColumnHeadersHeight = 38;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            cellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grid.DefaultCellStyle = cellStyle;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.grid.Location = new System.Drawing.Point(0, 150);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 32;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1000, 450);
            this.grid.TabIndex = 1;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grid_CellFormatting);
            //
            // UcMonitoring
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pnlTop);
            this.Name = "UcMonitoring";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
