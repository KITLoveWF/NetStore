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

namespace NetStore.Form.FormLoginAndFoget
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StaffDAO staffDAO = new StaffDAO();
            DataTable dt = staffDAO.FindStaff(txtUsername.Text, txtPassword.Text);
            LoginSave.Username = txtUsername.Text;
            LoginSave.Password = txtPassword.Text;
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string info = $"ID: {row["staffID"]}\n" +
                              $"Tên: {row["nameStaff"]}\n" +
                              $"Username: {row["username"]}\n" +
                              $"Password: {row["password"]}";

                MessageBox.Show("Đăng nhập thành công!\n\n" + info);

                this.Hide();
                StateComputer stateComputer = new StateComputer();
                stateComputer.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
