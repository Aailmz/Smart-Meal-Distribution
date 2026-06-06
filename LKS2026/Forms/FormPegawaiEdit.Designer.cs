namespace LKS2026.Forms
{
    partial class FormPegawaiEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.TextBox txtAlamat;
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
            this.lblJabatan = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
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
            this.lblNama.Size = new System.Drawing.Size(110, 19);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Pegawai *";
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
            // lblJabatan
            //
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJabatan.Location = new System.Drawing.Point(30, 80);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(65, 19);
            this.lblJabatan.TabIndex = 2;
            this.lblJabatan.Text = "Jabatan";
            //
            // txtJabatan
            //
            this.txtJabatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJabatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJabatan.Location = new System.Drawing.Point(30, 102);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(400, 25);
            this.txtJabatan.TabIndex = 3;
            //
            // lblHp
            //
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHp.Location = new System.Drawing.Point(30, 140);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(70, 19);
            this.lblHp.TabIndex = 4;
            this.lblHp.Text = "Nomor HP";
            //
            // txtHp
            //
            this.txtHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHp.Location = new System.Drawing.Point(30, 162);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(400, 25);
            this.txtHp.TabIndex = 5;
            //
            // lblAlamat
            //
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlamat.Location = new System.Drawing.Point(30, 200);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(55, 19);
            this.lblAlamat.TabIndex = 6;
            this.lblAlamat.Text = "Alamat";
            //
            // txtAlamat
            //
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlamat.Location = new System.Drawing.Point(30, 222);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(400, 60);
            this.txtAlamat.TabIndex = 7;
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(160, 290);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 38);
            this.btnSimpan.TabIndex = 8;
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
            this.btnBatal.Location = new System.Drawing.Point(300, 290);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(130, 38);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            //
            // FormPegawaiEdit
            //
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblJabatan);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPegawaiEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Pegawai";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
