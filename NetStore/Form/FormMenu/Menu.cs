using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NetStore.Form.FormMenu
{
    public partial class Menu: System.Windows.Forms.Form
    {
        // Tạo 2 biến cục bộ : 
        string strCon = @"Data Source =DESKTOP-8PBDD22\DANHNGUYEN; Initial Catalog=Test; Integrated Security=True";
        // Đối tượng kết nối 
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
