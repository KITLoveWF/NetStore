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
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            guna2DataGridView1.EnableHeadersVisualStyles = false; // Tắt hiệu ứng mặc định
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            //string hexColor = "#E5E1E1"; 
            //guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(hexColor);
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Chỉnh màu chữ để dễ đọc
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            Color cellColor = Color.FromArgb(239, 236, 236); // Màu xám nhạt
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = cellColor;
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
