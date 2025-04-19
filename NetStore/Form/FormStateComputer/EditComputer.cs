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
    public partial class EditComputer : System.Windows.Forms.Form
    {
        public int id;
        public EditComputer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditcomputer_Click(object sender, EventArgs e)
        {
            string status = "";
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
            if (cbxTypecomputer.SelectedItem == null || txtMoney.Text == "" || txtNamecomputer.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin máy tính!", "Cập nhật máy tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMoney.Text != "" && !double.TryParse(txtMoney.Text, out double money))
            {
                MessageBox.Show("Sai giá máy tính!", "Cập nhật máy tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxTypecomputer.SelectedItem != null && txtMoney.Text != "" && txtNamecomputer.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật máy tính?", "Cập nhật máy tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Computer computer = new Computer(status, Convert.ToDouble(txtMoney.Text), txtNamecomputer.Text);
                    computer.Id = id;
                    ComputerDAO computerDAO = new ComputerDAO();
                    computerDAO.Fix(computer);
                    this.DialogResult = DialogResult.OK; // Trả về kết quả
                    this.Close(); // Đóng form
                }
            }
        }
    }
}
