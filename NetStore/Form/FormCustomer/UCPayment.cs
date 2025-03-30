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
    public partial class UCPayment: UserControl
    {
        public UCPayment()
        {
            InitializeComponent();
        }

        private void UCPayment_Load(object sender, EventArgs e)
        {
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


            guna2DataGridView1.Rows.Add("Hamburger Bò", "50,000 VND", "2", "100,000 VND");
            guna2DataGridView1.Rows.Add("Gà Rán Combo", "120,000 VND", "1", "120,000 VND");
            guna2DataGridView1.Rows.Add("Pizza Hải Sản", "220,000 VND", "1", "220,000 VND");
            guna2DataGridView1.Rows.Add("Khoai Tây Chiên", "35,000 VND", "3", "105,000 VND");
            guna2DataGridView1.Rows.Add("Hotdog Phô Mai", "45,000 VND", "2", "90,000 VND");
            guna2DataGridView1.Rows.Add("Trà Sữa Trân Châu", "40,000 VND", "2", "80,000 VND");
            guna2DataGridView1.Rows.Add("Coca-Cola Lon", "20,000 VND", "3", "60,000 VND");


        }
    }
}
