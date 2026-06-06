namespace LKS2026.Forms
{
    partial class FormBahanBakuEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblNama
            //
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNama.Location = new System.Drawing.Point(30, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(95, 19);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Bahan *";
            //
            // txtNama
            //
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNama.Location = new System.Drawing.Point(30, 42);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(400, 25);
            this.txtNama.TabIndex = 1;
            //
            // lblKategori
            //
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(30, 80);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 19);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori";
            //
            // cmbKategori
            //
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.Items.AddRange(new object[] {
            "Karbohidrat",
            "Protein",
            "Sayuran",
            "Buah",
            "Bumbu",
            "Minuman",
            "Lainnya"});
            this.cmbKategori.Location = new System.Drawing.Point(30, 102);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(400, 25);
            this.cmbKategori.TabIndex = 3;
            //
            // lblSatuan
            //
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSatuan.Location = new System.Drawing.Point(30, 140);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(55, 19);
            this.lblSatuan.TabIndex = 4;
            this.lblSatuan.Text = "Satuan";
            //
            // cmbSatuan
            //
            this.cmbSatuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSatuan.Items.AddRange(new object[] {
            "kg",
            "gram",
            "liter",
            "ml",
            "butir",
            "ikat",
            "papan",
            "buah",
            "pack"});
            this.cmbSatuan.Location = new System.Drawing.Point(30, 162);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(400, 25);
            this.cmbSatuan.TabIndex = 5;
            //
            // lblStok
            //
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStok.Location = new System.Drawing.Point(30, 200);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(70, 19);
            this.lblStok.TabIndex = 6;
            this.lblStok.Text = "Stok Awal";
            //
            // txtStok
            //
            this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStok.Location = new System.Drawing.Point(30, 222);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(400, 25);
            this.txtStok.TabIndex = 7;
            this.txtStok.Text = "0";
            //
            // lblHarga
            //
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHarga.Location = new System.Drawing.Point(30, 260);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(160, 19);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "Harga Perkiraan (Rp)";
            //
            // txtHarga
            //
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHarga.Location = new System.Drawing.Point(30, 282);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(400, 25);
            this.txtHarga.TabIndex = 9;
            this.txtHarga.Text = "0";
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(160, 330);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 38);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            //
            // btnBatal
            //
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(300, 330);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(130, 38);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            //
            // FormBahanBakuEdit
            //
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.cmbSatuan);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBahanBakuEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Bahan Baku";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
