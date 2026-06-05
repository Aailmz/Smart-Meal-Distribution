using System;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.Forms
{
    public partial class FormSekolahEdit : Form
    {
        private readonly int? _id;
        public FormSekolahEdit() { InitializeComponent(); Text = "Tambah Sekolah"; }
        public FormSekolahEdit(int id) : this()
        {
            _id = id;
            Text = "Ubah Sekolah";
            LoadEntity();
        }

        private void LoadEntity()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM Schools WHERE SchoolId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0) { UiHelper.Warn("Data tidak ditemukan."); Close(); return; }
                var r = dt.Rows[0];
                txtNama.Text = r["SchoolName"].ToString();
                txtAlamat.Text = r["Address"].ToString();
                txtPic.Text = r["PICName"].ToString();
                txtHp.Text = r["PICPhone"].ToString();
                numSiswa.Value = Convert.ToDecimal(r["StudentCount"]);
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat: " + ex.Message); }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) { UiHelper.Warn("Nama sekolah wajib diisi."); return; }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(@"UPDATE Schools SET SchoolName=@n, Address=@a, PICName=@p, PICPhone=@h, StudentCount=@s WHERE SchoolId=@i",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@a", txtAlamat.Text.Trim()),
                        Database.P("@p", txtPic.Text.Trim()),
                        Database.P("@h", txtHp.Text.Trim()),
                        Database.P("@s", (int)numSiswa.Value),
                        Database.P("@i", _id.Value));
                }
                else
                {
                    Database.Execute(@"INSERT INTO Schools (SchoolName, Address, PICName, PICPhone, StudentCount) VALUES (@n,@a,@p,@h,@s)",
                        Database.P("@n", txtNama.Text.Trim()),
                        Database.P("@a", txtAlamat.Text.Trim()),
                        Database.P("@p", txtPic.Text.Trim()),
                        Database.P("@h", txtHp.Text.Trim()),
                        Database.P("@s", (int)numSiswa.Value));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { UiHelper.Error("Gagal menyimpan: " + ex.Message); }
        }

        private void BtnBatal_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
