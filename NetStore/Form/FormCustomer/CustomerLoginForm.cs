using NetStore.DAO;
using NetStore.Form.FormStateComputer;
using NetStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.FormCustomer
{
    public partial class CustomerLoginForm: System.Windows.Forms.Form
    {
        private int computerID = 1;
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            CustomerDAO customerDAO = new CustomerDAO();
            NetStore.Model.Customer customer = customerDAO.Login(username, password);

            if (customer != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                this.Hide();
                ReceiptDAO receiptDAO = new ReceiptDAO();
                Receipt receipt1 = new Receipt(computerID, customer.Id, DateTime.Now);
                if(receiptDAO.AddReceipt(receipt1))
                {
                    NetStore.Model.Receipt receipt = receiptDAO.FindActiveReceiptByCustomerID(customer.Id);
                    CustomerForm customerForm = new CustomerForm(customer, receipt);
                    customerForm.Show();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống đăng nhập!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
