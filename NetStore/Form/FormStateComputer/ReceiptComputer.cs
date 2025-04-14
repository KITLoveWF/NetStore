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

namespace NetStore.Form.FormStateComputer
{
    public partial class ReceiptComputer : System.Windows.Forms.Form
    {
        public string Computer {  get; set; }
        public ReceiptComputer()
        {
            InitializeComponent();
            ComputerDAO computerDAO = new ComputerDAO();
            DataTable dataTable = computerDAO.LoadDB();
            foreach (DataRow row in dataTable.Rows) 
            {
                cbxComputer.Items.Add(row["nameComputer"].ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChooseComputer_Click(object sender, EventArgs e)
        {
            if (cbxComputer.SelectedItem != null)
            {
                Computer = cbxComputer.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK; // Trả về kết quả
                this.Close(); // Đóng form
            }
            //ComputerDAO computerDAO = new ComputerDAO();
            //DataTable dataTable = computerDAO.FindComputer(computer);

        }

    }
}
