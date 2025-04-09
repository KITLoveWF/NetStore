using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetStore.Form.FormLoginAndFoget;
using NetStore.Model;
namespace NetStore.Form.FormCustomer
{
    public partial class CustomerForm: System.Windows.Forms.Form
    {
        private NetStore.Model.Customer customer;
        private NetStore.Model.Receipt receipt;

        public CustomerForm(NetStore.Model.Customer customer, NetStore.Model.Receipt receipt)
        {
            this.customer = customer;
            this.receipt = receipt;
            InitializeComponent();
            this.ucCustomerOrderFood1.SetCustomer(customer);
            this.ucCustomerOrderFood1.SetReceipt(receipt);
            this.ucPayment1.SetCustomer(customer);
            this.ucPayment1.SetReceipt(receipt);
            this.ucPayment1.CheckoutCompleted += (s, e) =>
            {
                this.Close(); // hoặc this.Close();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            };
        }

        private void ucCustomerSideLeft1_Load(object sender, EventArgs e)
        {
            this.ucCustomerOrderFood1.Hide();
            this.ucPayment1.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.ucPayment1.Hide();
            this.ucCustomerOrderFood1.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.ucCustomerOrderFood1.Hide();
            this.ucPayment1.Show();
            this.ucPayment1.RecalculateCost();

        }
    }
}
