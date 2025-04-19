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

namespace NetStore.Form.FormStateComputer
{
    public partial class AddComputer : System.Windows.Forms.Form
    {
        public AddComputer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddcomputer_Click(object sender, EventArgs e)
        {
            string status = "";
            
            if(cbxTypecomputer.SelectedItem == null || txtMoney.Text == "" || txtNamecomputer.Text =="")
            {
                MessageBox.Show("Chưa nhập thông tin máy tính!", "Tạo máy tính",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
            else if(txtMoney.Text != "" && !double.TryParse(txtMoney.Text, out double money))
            {
                MessageBox.Show("Sai giá máy tính!", "Tạo máy tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else if(cbxTypecomputer.SelectedItem != null && txtMoney.Text != "" && txtNamecomputer.Text != "")
            {
                if (cbxTypecomputer.SelectedItem.ToString() == "Online")
                {
                    status = "1";
                }
                if (cbxTypecomputer.SelectedItem.ToString() == "Offline")
                {
                    status = "2";
                }
                if (cbxTypecomputer.SelectedItem.ToString() == "Error")
                {
                    status = "3";
                }

                MessageBox.Show("Tạo máy tính thành công!", "Tạo máy tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Computer computer = new Computer(status, Convert.ToDouble(txtMoney.Text), txtNamecomputer.Text);
                ComputerDAO computerDAO = new ComputerDAO();
                computerDAO.Add(computer);
                this.DialogResult = DialogResult.OK; // Trả về kết quả
                this.Close(); // Đóng form

            }    

            
        }
    }
}
