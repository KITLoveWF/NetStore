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
    public partial class StateComputer : System.Windows.Forms.Form
    {
        public StateComputer()
        {
            InitializeComponent();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucMenu1.Hide();
            this.ucCustomer1.Hide();
            ucSideLeft1.btnStatecomputer.Click += performStateComputer;
            ucSideLeft1.btnImport.Click += performImport;
            ucSideLeft1.btnTotalreceipt.Click += performInvoice;
            ucSideLeft1.btnError.Click += performError;
        }
        private void performStateComputer(object sender, EventArgs e)
        {
            this.ucFormStateComputer1.Show();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
        }
        private void performImport(object sender, EventArgs e)
        {
            this.ucImport1.Show();
            this.ucFormStateComputer1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
        }
        private void performInvoice(object sender, EventArgs e)
        {
            this.ucInvoice1.Show();
            this.ucFormStateComputer1.Hide();
            this.ucImport1.Hide();
            this.ucCompMaintainaceForm1.Hide();
        }
        private void performError(object sender, EventArgs e)
        {
            this.ucInvoice1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucImport1.Hide();
            this.ucCompMaintainaceForm1.Show();
        }


    }
}
