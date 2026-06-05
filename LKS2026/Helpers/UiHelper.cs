using System;
using System.Drawing;
using System.Windows.Forms;

namespace LKS2026.Helpers
{
    public static class UiHelper
    {
        /// <summary>Terapkan style modern ke DataGridView.</summary>
        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Color.FromArgb(230, 230, 230);
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.RowTemplate.Height = 32;
            grid.EnableHeadersVisualStyles = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersDefaultCellStyle.BackColor = UiTheme.Primary;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }

        public static Button MakeActionButton(string text, Color bg, EventHandler onClick)
        {
            var b = new Button
            {
                Text = text,
                Size = new Size(110, 36),
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            b.Click += onClick;
            return b;
        }

        public static TextBox MakeTextBox(int width = 240)
        {
            return new TextBox
            {
                Width = width,
                Height = 30,
                Font = UiTheme.FontNormal,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        public static Label MakeLabel(string text, bool bold = false)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = bold ? UiTheme.FontBold : UiTheme.FontNormal,
                ForeColor = Color.FromArgb(33, 37, 41)
            };
        }

        public static bool ConfirmDelete(string entityName)
        {
            return MessageBox.Show(
                $"Yakin ingin menghapus {entityName} yang dipilih?\nTindakan ini tidak dapat dibatalkan.",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        public static void Info(string msg) =>
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Warn(string msg) =>
            MessageBox.Show(msg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void Error(string msg) =>
            MessageBox.Show(msg, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
