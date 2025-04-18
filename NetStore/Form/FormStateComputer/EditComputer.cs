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
            Computer computer = new Computer(status, Convert.ToDouble(txtMoney.Text), txtNamecomputer.Text);
            computer.Id = id;
            ComputerDAO computerDAO = new ComputerDAO();
            computerDAO.Fix(computer);
        }
    }
}
