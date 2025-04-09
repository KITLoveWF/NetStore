using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetStore.DAO;
using NetStore.Model;

namespace NetStore.Form
{
    public partial class UCPayment: UserControl
    {
        public event EventHandler CheckoutCompleted;

        ReceiptDAO receiptDAO = new ReceiptDAO();
        decimal serviceCost = 0;
        decimal computerServicePrice = 0;
        decimal totalPrice = 0;
        private Timer autoRefreshTimer = new Timer();

        private NetStore.Model.Customer customer;
        private NetStore.Model.Receipt receipt;
        public UCPayment()
        {
            InitializeComponent();
        }
        public void SetCustomer(NetStore.Model.Customer customer)
        {
            this.customer = customer;
        }
        public void SetReceipt(NetStore.Model.Receipt receipt)
        {
            this.receipt = receipt;
        }
        private void UCPayment_Load(object sender, EventArgs e)
        {
            RecalculateCost();

            autoRefreshTimer.Interval = 60 * 1000; // mỗi phút
            autoRefreshTimer.Tick += (s, ev) => RecalculateCost();
            autoRefreshTimer.Start();

        }
        public void RecalculateCost()
        {
            OrderServiceDetailLoad(); // cập nhật lại serviceCost
            ComputerServiceDetailLoad(); // cập nhật lại computerServicePrice
            totalPrice = serviceCost + computerServicePrice;
            lblTotalPrice.Text = string.Format("{0:#,##0} VND", totalPrice);
        }


        private void OrderServiceDetailLoad()
        {
            dgvOrderDetail.EnableHeadersVisualStyles = false;
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgvOrderDetail.DefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvOrderDetail.DefaultCellStyle.ForeColor = Color.Black;
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvOrderDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 236, 236);

            DataTable dt = receiptDAO.GetOrderServiceDetailsByReceiptID(receipt.ReceiptID);

            // Tính tổng 'Thành tiền'
            serviceCost = 0;
            foreach (DataRow row in dt.Rows)
            {
                serviceCost += Convert.ToDecimal(row["Thành tiền"]);
            }

            // Thêm dòng "Tổng tiền"
            DataRow totalRow = dt.NewRow();
            totalRow["Tên mặt hàng"] = "Tổng tiền";
            totalRow["Đơn giá"] = DBNull.Value;
            totalRow["Số lượng"] = DBNull.Value;
            totalRow["Thành tiền"] = serviceCost;
            dt.Rows.Add(totalRow);

            dgvOrderDetail.DataSource = dt;
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.AllowUserToDeleteRows = false;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Format tiền tệ cho cột "Đơn giá" và "Thành tiền"
            dgvOrderDetail.CellFormatting += (s, e) =>
            {
                string columnName = dgvOrderDetail.Columns[e.ColumnIndex].Name;
                if ((columnName == "Đơn giá" || columnName == "Thành tiền") && e.Value != null && e.Value is decimal)
                {
                    e.Value = string.Format("{0:#,##0} VND", e.Value);
                    e.FormattingApplied = true;
                }
            };

            // Làm nổi bật dòng tổng
            int lastRow = dgvOrderDetail.Rows.Count - 1;
            if (lastRow >= 0)
            {
                dgvOrderDetail.Rows[lastRow].DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                dgvOrderDetail.Rows[lastRow].DefaultCellStyle.BackColor = Color.LightYellow;
            }

            // Căn lề phải cho cột tiền
            //dgvOrderDetail.Columns["Đơn giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvOrderDetail.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void ComputerServiceDetailLoad()
        {
            DataTable dt = receiptDAO.GetComputerUsageDetailByReceiptID(receipt.ReceiptID);
            foreach (DataRow row in dt.Rows)
            {
                string computerName = row["Máy số"].ToString();
                string time = row["Tổng phút chơi"].ToString();
                decimal computerPrice = Convert.ToDecimal(row["Đơn giá"]);
                // Ép kiểu và format giá
                computerServicePrice = Convert.ToDecimal(row["Tiền máy tạm tính"]);
                string formattedTotalPrice = string.Format("{0:#,##0} VND", computerServicePrice);
                string formattedPrice = string.Format("{0:#,##0} VND", computerPrice);

                lblComputerName.Text = computerName;
                lblTime.Text = time;
                lblComputerPrice.Text = formattedPrice;
                lblTotalComputerPrice.Text = formattedTotalPrice;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc muốn dừng phiên chơi không?",
                "Xác nhận dừng phiên chơi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                RecalculateCost(); // cập nhật thông tin mới nhất trước khi thanh toán

                // Giả sử bạn có hàm này trong ReceiptDAO
                receipt.TimeEnd = DateTime.Now;
                receipt.ComputerCost = computerServicePrice;
                receipt.ServiceCost = serviceCost;
                receipt.TotalPrice = totalPrice;
                bool result = receiptDAO.UpdateReceipt(receipt);

                if (result)
                {
                    MessageBox.Show("Hãy ra quầy để tiến hành thanh toán!");
                    CheckoutCompleted?.Invoke(this, EventArgs.Empty);


                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình dừng phiên.");
                }
            }
        }


    }

}
