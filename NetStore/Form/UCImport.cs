using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form
{
    public partial class UCImport: UserControl
    {
        public UCImport()
        {
            InitializeComponent();
        }

        private void UCImport_Load(object sender, EventArgs e)
        {
            dgvImportRecord.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvImportRecord.EnableHeadersVisualStyles = false; // Tắt hiệu ứng mặc định
            dgvImportRecord.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            //string hexColor = "#E5E1E1"; 
            //guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(hexColor);
            dgvImportRecord.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvImportRecord.DefaultCellStyle.ForeColor = Color.Black; // Chỉnh màu chữ để dễ đọc
            dgvImportRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvImportRecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            Color cellColor = Color.FromArgb(239, 236, 236); // Màu xám nhạt
            dgvImportRecord.AlternatingRowsDefaultCellStyle.BackColor = cellColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCyphergaming_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
