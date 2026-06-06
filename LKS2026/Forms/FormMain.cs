using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;
using LKS2026.UserControls;

namespace LKS2026.Forms
{
    public partial class FormMain : Form
    {
        private readonly List<MenuButton> _menuButtons = new List<MenuButton>();
        private MenuButton _activeButton;

        private class MenuButton
        {
            public string Key;
            public Button Button;
            public Func<UserControl> Factory;
        }

        public FormMain()
        {
            InitializeComponent();
            BuildMenu();
            UpdateHeader();
            // Default ke Dashboard
            ActivateMenu(_menuButtons[0]);
        }

        private void BuildMenu()
        {
            // Sesuai Tabel 6 TOR LKS 2026:
            // Petugas SPPG  : input & kelola data operasional (master data + kebutuhan dapur + pesanan)
            // Supervisor SPPG: lihat dashboard, monitoring, laporan, validasi status

            AddMenu("Dashboard",                        () => new UcDashboard());        // semua role
            AddMenu("Data Pegawai",                     () => new UcPegawai(),         petugasOnly: true);
            AddMenu("Data Bahan Baku",                  () => new UcBahanBaku(),       petugasOnly: true);
            AddMenu("Data Sekolah Penerima",            () => new UcSekolah(),         petugasOnly: true);
            AddMenu("Kebutuhan Dapur SPPG",             () => new UcKebutuhanDapur(),  petugasOnly: true);
            AddMenu("Pesanan ke Pemasok",               () => new UcPesananPemasok()); // Petugas input, Supervisor monitor + validasi
            AddMenu("Monitoring Produksi & Distribusi", () => new UcMonitoring(),      supervisorOnly: true);
            AddMenu("Laporan",                          () => new UcLaporan(),         supervisorOnly: true);
            AddMenu("Profil",                           () => new UcProfil());          // semua role
        }

        private void AddMenu(string label, Func<UserControl> factory, bool supervisorOnly = false, bool petugasOnly = false)
        {
            // Hide menu jika role tidak match
            if (supervisorOnly && !Session.IsSupervisor) return;
            if (petugasOnly && !Session.IsPetugas) return;

            var btn = new Button
            {
                Text = "   " + label,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 46,
                BackColor = Color.FromArgb(33, 37, 41),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Regular),
                Cursor = Cursors.Hand,
                Padding = new Padding(10, 0, 0, 0)
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);

            var entry = new MenuButton { Key = label, Button = btn, Factory = factory };
            btn.Click += (s, e) => ActivateMenu(entry);

            // tambahkan ke awal panel agar urutan benar (Top-dock stack reverse)
            pnlSidebarMenu.Controls.Add(btn);
            btn.BringToFront();

            _menuButtons.Add(entry);
        }

        private void ActivateMenu(MenuButton entry)
        {
            if (_activeButton != null)
            {
                _activeButton.Button.BackColor = Color.FromArgb(33, 37, 41);
                _activeButton.Button.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }

            entry.Button.BackColor = Color.FromArgb(0, 120, 215);
            entry.Button.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            _activeButton = entry;

            lblPageTitle.Text = entry.Key;

            pnlContent.SuspendLayout();
            foreach (Control c in pnlContent.Controls) c.Dispose();
            pnlContent.Controls.Clear();

            try
            {
                var uc = entry.Factory();
                uc.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(uc);
            }
            catch (Exception ex)
            {
                var lbl = new Label
                {
                    Text = "Gagal memuat halaman: " + ex.Message,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(220, 53, 69),
                    Font = new Font("Segoe UI", 10F)
                };
                pnlContent.Controls.Add(lbl);
            }
            pnlContent.ResumeLayout();
        }

        private void UpdateHeader()
        {
            lblUser.Text = Session.FullName ?? "-";
            lblRole.Text = Session.Role == "PetugasSPPG" ? "Petugas SPPG" : "Supervisor SPPG";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show(
                "Anda akan keluar dari sistem. Lanjutkan?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            Session.Clear();
            DialogResult = DialogResult.Retry; // signal Program.cs untuk kembali ke login
            Close();
        }
    }
}
