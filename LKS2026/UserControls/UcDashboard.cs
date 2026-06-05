using System;
using System.Drawing;
using System.Windows.Forms;
using LKS2026.Helpers;

namespace LKS2026.UserControls
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            BuildCards();
        }

        private int ScalarInt(string sql)
        {
            var v = Database.Scalar(sql);
            return v == null || v == DBNull.Value ? 0 : Convert.ToInt32(v);
        }

        private void BuildCards()
        {
            try
            {
                int totPeg  = ScalarInt("SELECT COUNT(*) FROM Employees");
                int totBhn  = ScalarInt("SELECT COUNT(*) FROM RawMaterials");
                int totSek  = ScalarInt("SELECT COUNT(*) FROM Schools");
                int totPsn  = ScalarInt("SELECT COUNT(*) FROM SupplierOrders");
                int psnPnd  = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Pending'");
                int psnDpr  = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Diproses'");
                int psnSls  = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Selesai'");
                int totDst  = ScalarInt("SELECT COUNT(*) FROM ProductionDistribution");

                flowCards.Controls.Clear();
                flowCards.Controls.Add(MakeCard("Total Pegawai",         totPeg.ToString(),  UiTheme.Primary));
                flowCards.Controls.Add(MakeCard("Total Bahan Baku",      totBhn.ToString(),  UiTheme.Info));
                flowCards.Controls.Add(MakeCard("Total Sekolah",         totSek.ToString(),  UiTheme.Success));
                flowCards.Controls.Add(MakeCard("Total Pesanan",         totPsn.ToString(),  UiTheme.PrimaryDark));
                flowCards.Controls.Add(MakeCard("Pesanan Pending",       psnPnd.ToString(),  UiTheme.Warning));
                flowCards.Controls.Add(MakeCard("Pesanan Diproses",      psnDpr.ToString(),  UiTheme.Info));
                flowCards.Controls.Add(MakeCard("Pesanan Selesai",       psnSls.ToString(),  UiTheme.Success));
                flowCards.Controls.Add(MakeCard("Data Distribusi",       totDst.ToString(),  UiTheme.PrimaryDark));
            }
            catch (Exception ex) { UiHelper.Error("Gagal memuat dashboard: " + ex.Message); }
        }

        private Panel MakeCard(string title, string value, Color color)
        {
            var card = new Panel
            {
                Width = 240, Height = 130,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(0)
            };

            // Strip warna di kiri
            var strip = new Panel { Width = 6, Dock = DockStyle.Left, BackColor = color };
            card.Controls.Add(strip);

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = UiTheme.Muted,
                AutoSize = false,
                Location = new Point(20, 18),
                Size = new Size(210, 24)
            };
            var lblVal = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 30F, FontStyle.Bold),
                ForeColor = color,
                AutoSize = false,
                Location = new Point(20, 45),
                Size = new Size(210, 55)
            };
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblVal);

            // Subtle border via Paint
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            };
            return card;
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => BuildCards();
    }
}
