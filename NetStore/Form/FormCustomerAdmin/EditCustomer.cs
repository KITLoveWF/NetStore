using NetStore.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.Customer
{
    public partial class EditCustomer : System.Windows.Forms.Form
    {
        private int index;
        public bool isClick = false;
        public EditCustomer(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu!", "Cập nhập tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật tài khoản?", "Cập nhập tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    var customer = new NetStore.Model.Customer(txtUsername.Text, txtPassword.Text);
                    CustomerDAO customerDAO = new CustomerDAO();
                    customer.Id = index;
                    customerDAO.Fix(customer);
                    this.DialogResult = DialogResult.OK; // Trả về kết quả
                    this.Close();
                }
                
                //MessageBox.Show($"{txtUsername.Text}");
                

            }
            isClick = true;
        }
    }
}
