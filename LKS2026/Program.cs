using System;
using System.Windows.Forms;
using LKS2026.Forms;
using LKS2026.Helpers;

namespace LKS2026
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Database.TestConnection(out string err))
            {
                MessageBox.Show(
                    "Tidak dapat terkoneksi ke database SQL Server.\n\n" +
                    "Detail error:\n" + err + "\n\n" +
                    "Pastikan SQL Server (LocalDB) berjalan dan database SPPGDb sudah dibuat.\n" +
                    "Jalankan script: Database\\database.sql terlebih dahulu.",
                    "Koneksi Database Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                using (var login = new FormLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                using (var main = new FormMain())
                {
                    var result = main.ShowDialog();
                    if (result != DialogResult.Retry) break;
                }
            }
        }
    }
}
