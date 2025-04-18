using NetStore.DAO;
using NetStore.Form.FormCustomer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NetStore.Form.FormLoginAndFoget
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private int computerID = 1;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(cbAdmin.Checked && cbCustomer.Checked == false)
            {
                StaffDAO staffDAO = new StaffDAO();
                DataTable dt = staffDAO.FindStaff(txtUsername.Text, txtPassword.Text);
                LoginSave.Username = txtUsername.Text;
                LoginSave.Password = txtPassword.Text;
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MessageBox.Show("Đăng nhập thành công!", "Đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    StateComputer stateComputer = new StateComputer();
                    stateComputer.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!","Đăng nhập",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            else if (cbAdmin.Checked == false && cbCustomer.Checked)
            {
                CustomerDAO customerDAO = new CustomerDAO();
                NetStore.Model.Customer customer = customerDAO.Login(txtUsername.Text, txtPassword.Text);
                LoginSave.Username = txtUsername.Text;
                LoginSave.Password = txtPassword.Text;
                if (customer != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ReceiptDAO receiptDAO = new ReceiptDAO();
                    Receipt receipt1 = new Receipt(computerID, customer.Id, DateTime.Now);
                    if (receiptDAO.AddReceipt(receipt1))
                    {
                        NetStore.Model.Receipt receipt = receiptDAO.FindActiveReceiptByCustomerID(customer.Id);
                        CustomerForm customerForm = new CustomerForm(customer, receipt);
                        customerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(cbCustomer.Checked == false && cbCustomer.Checked == false)
            {
                MessageBox.Show("Chưa chọn vai trò!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cbCustomer.Checked == true && cbCustomer.Checked == true)
            {
                MessageBox.Show("Chọn sai vai trò!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }
    }
}
