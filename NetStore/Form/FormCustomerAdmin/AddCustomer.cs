using NetStore.DAO;
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
namespace NetStore.Form.FormCustomerAdmin
{
    public partial class AddCustomer : System.Windows.Forms.Form
    {
        public bool isClick = false;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Customer customer =  new Customer(txtUsername.Text,txtPassword.Text);
            var customer = new NetStore.Model.Customer(txtUsername.Text, txtPassword.Text);
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.Add(customer);
            isClick = true;
            //MessageBox.Show("Thêm tài khoản thành công");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
