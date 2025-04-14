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
    public partial class UCInvoice: UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();
        }

        private void UCInvoice_Load(object sender, EventArgs e)
        {
            dgvInvoice.EnableHeadersVisualStyles = false; // Tắt hiệu ứng mặc định
            dgvInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            //string hexColor = "#E5E1E1"; 
            //guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(hexColor);
            dgvInvoice.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvInvoice.DefaultCellStyle.ForeColor = Color.Black; // Chỉnh màu chữ để dễ đọc
            dgvInvoice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvInvoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            Color cellColor = Color.FromArgb(239, 236, 236); // Màu xám nhạt
            dgvInvoice.AlternatingRowsDefaultCellStyle.BackColor = cellColor;


            //dgvInvoice.Rows.Add("2025-03-17", "Nguyen Van A", "Sales", "1,500,000 VND", "200,000 VND", "800,000 VND", "2,100,000 VND");
            //dgvInvoice.Rows.Add("2025-03-16", "Tran Thi B", "Purchase", "2,000,000 VND", "250,000 VND", "900,000 VND", "2,650,000 VND");
            //dgvInvoice.Rows.Add("2025-03-15", "Le Van C", "Sales", "1,800,000 VND", "220,000 VND", "850,000 VND", "2,430,000 VND");
            //dgvInvoice.Rows.Add("2025-03-14", "Pham Thi D", "Refund", "1,200,000 VND", "180,000 VND", "700,000 VND", "1,720,000 VND");
            //dgvInvoice.Rows.Add("2025-03-13", "Hoang Van E", "Sales", "2,500,000 VND", "300,000 VND", "1,200,000 VND", "3,400,000 VND");

        }
    }
}
