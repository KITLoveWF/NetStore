using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form
{
    public partial class UCCustomerOrderFood: UserControl
    {
        public UCCustomerOrderFood()
        {
            InitializeComponent();
            LoadInventoryToFlowLayout();
        }

        private void lblCyphergaming_Click(object sender, EventArgs e)
        {

        }
        InventoryDAO inventoryDAO = new InventoryDAO();

        private void LoadInventoryToFlowLayout()
        {
            flowLayoutPanelFoods.Controls.Clear(); // Xóa các UC cũ (nếu có)

            DataTable dt = inventoryDAO.GetAllInventories();

            foreach (DataRow row in dt.Rows)
            {
                UCSingleFood food = new UCSingleFood();
                string name = row["nameInventory"].ToString();
                food.SetName(name);

                flowLayoutPanelFoods.Controls.Add(food);
            }
        }
    }
}
