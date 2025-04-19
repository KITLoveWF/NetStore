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

namespace NetStore.Form.FormMenu
{
    public partial class AddNewFood : System.Windows.Forms.Form
    {
        private string path;
        public AddNewFood()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(cbxName.SelectedItem == null||txtPrice.Text == "" || cbxCategory.SelectedItem == null ||path =="")
            {
                MessageBox.Show("Chưa nhập hoặc chọn thông tin món ăn hoặc thẻ cào!", "Tạo món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPrice.Text != "" && !double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Giá món ăn hoặc thẻ cào sai!", "Tạo món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(cbxName.SelectedItem!=null && txtPrice.Text != "" && cbxCategory.SelectedItem!=null && path != "")
            {
                MessageBox.Show("Tạo món ăn hoặc thẻ cào thành công!", "Tạo món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string nameInventory = cbxName.SelectedItem.ToString();
                double sellingPrice = Convert.ToDouble(txtPrice.Text);
                string type = cbxCategory.SelectedItem.ToString();
                string image = path;
                Inventory inventory = new Inventory(nameInventory, sellingPrice, image, type);
                InventoryDAO inventoryDAO = new InventoryDAO();
                inventoryDAO.UpdateMenu(inventory);
                this.DialogResult = DialogResult.OK; // Trả về kết quả
                this.Close();
            }    
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                ptxImage.Image = Image.FromFile(path);
                ptxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
