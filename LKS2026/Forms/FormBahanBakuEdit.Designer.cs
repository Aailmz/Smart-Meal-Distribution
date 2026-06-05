using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    partial class FormBahanBakuEdit
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNama, txtStok, txtHarga;
        private ComboBox cmbKategori, cmbSatuan;
        private Button btnSimpan, btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.ClientSize = new Size(460, 400);
            this.BackColor = Color.White;

            int x = 30, w = 400, y = 20;
            void Add(string label, Control c)
            {
                this.Controls.Add(new Label { Text = label, AutoSize = true, Font = UiTheme.FontBold, Location = new Point(x, y) });
                c.Location = new Point(x, y + 22);
                c.Width = w;
                this.Controls.Add(c);
                y += 60;
            }

            txtNama = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle };
            cmbKategori = new ComboBox { Font = UiTheme.FontNormal, DropDownStyle = ComboBoxStyle.DropDown };
            cmbKategori.Items.AddRange(new object[] { "Karbohidrat", "Protein", "Sayuran", "Buah", "Bumbu", "Minuman", "Lainnya" });
            cmbSatuan = new ComboBox { Font = UiTheme.FontNormal, DropDownStyle = ComboBoxStyle.DropDown };
            cmbSatuan.Items.AddRange(new object[] { "kg", "gram", "liter", "ml", "butir", "ikat", "papan", "buah", "pack" });
            txtStok = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle, Text = "0" };
            txtHarga = new TextBox { Font = UiTheme.FontNormal, BorderStyle = BorderStyle.FixedSingle, Text = "0" };

            Add("Nama Bahan *", txtNama);
            Add("Kategori", cmbKategori);
            Add("Satuan", cmbSatuan);
            Add("Stok Awal", txtStok);
            Add("Harga Perkiraan (Rp)", txtHarga);
            y += 10;

            btnSimpan = UiHelper.MakeActionButton("Simpan", UiTheme.Primary, BtnSimpan_Click);
            btnSimpan.Size = new Size(130, 38); btnSimpan.Location = new Point(x + w - 270, y);
            btnBatal = UiHelper.MakeActionButton("Batal", UiTheme.Muted, BtnBatal_Click);
            btnBatal.Size = new Size(130, 38); btnBatal.Location = new Point(x + w - 130, y);

            this.Controls.Add(btnSimpan);
            this.Controls.Add(btnBatal);
            this.AcceptButton = btnSimpan;
            this.CancelButton = btnBatal;
            this.ResumeLayout(false);
        }
    }
}
