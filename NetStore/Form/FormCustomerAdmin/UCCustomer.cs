using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.Customer
{
    public partial class UCCustomer: UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            // Tắt hiệu ứng mặc định
            dgvCustomer.EnableHeadersVisualStyles = false;

            // Thiết lập font và màu sắc cho tiêu đề cột
            dgvCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Thiết lập font, màu nền và màu chữ cho toàn bộ hàng
            dgvCustomer.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Italic); // Đổi toàn bộ font
            dgvCustomer.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvCustomer.DefaultCellStyle.ForeColor = Color.Black;

            // Thêm dữ liệu vào DataGridView
            //dgvCustomer.Rows.Add("Nguyen Van A", "0932466340", "van123", "abc123123");
            //dgvCustomer.Rows.Add("Tran Thi B", "0987654321", "tranb456", "xyz789456");
            //dgvCustomer.Rows.Add("Le Van C", "0911223344", "levc789", "pass123456");
            //dgvCustomer.Rows.Add("Pham Thi D", "0909456123", "phamtd321", "qwe456789");
            //dgvCustomer.Rows.Add("Hoang Van E", "0978543210", "hoange999", "asd987654");

        }
    }
}
