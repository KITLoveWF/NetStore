using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.ComputerMaintaince
{
    public partial class UCCompMaintainaceForm : UserControl
    {
        public UCCompMaintainaceForm()
        {
            InitializeComponent();
        }

        private void ucSideBarTopCompMaintain1_Load(object sender, EventArgs e)
        {

        }

        private void ucDeviceReceipt1_Load(object sender, EventArgs e)
        {

        }

        private void ucComputerState1_Load(object sender, EventArgs e)
        {

        }

        private void ucDeviceReceipt1_Load_1(object sender, EventArgs e)
        {

        }

        private void UCCompMaintainaceForm_Load(object sender, EventArgs e)
        {
            dgvDeviceRecord.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvDeviceRecord.EnableHeadersVisualStyles = false; // Tắt hiệu ứng mặc định
            dgvDeviceRecord.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            //string hexColor = "#E5E1E1"; 
            //guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(hexColor);
            dgvDeviceRecord.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvDeviceRecord.DefaultCellStyle.ForeColor = Color.Black; // Chỉnh màu chữ để dễ đọc
            dgvDeviceRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvDeviceRecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            Color cellColor = Color.FromArgb(239, 236, 236); // Màu xám nhạt
            dgvDeviceRecord.AlternatingRowsDefaultCellStyle.BackColor = cellColor;
        }
    }
}
