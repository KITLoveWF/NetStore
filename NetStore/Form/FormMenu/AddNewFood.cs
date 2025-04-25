using NetStore.DAO;
using NetStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string sourceFile = openFileDialog.FileName;
        //        string fileName = System.IO.Path.GetFileName(sourceFile);

        //        // Tạo thư mục Resources nếu chưa tồn tại
        //        string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
        //        string resourcesFolder = System.IO.Path.Combine(projectRoot, @"..\..\Resources");
        //        string targetFolder = System.IO.Path.GetFullPath(resourcesFolder);
        //        if (!System.IO.Directory.Exists(targetFolder))
        //        {
        //            System.IO.Directory.CreateDirectory(targetFolder);
        //        }

        //        // Copy ảnh vào thư mục Resources
        //        string destFile = System.IO.Path.Combine(targetFolder, fileName);
        //        System.IO.File.Copy(sourceFile, destFile, true);

        //        // Lưu đường dẫn tương đối
        //        path = System.IO.Path.Combine("Resources", fileName);

        //        // Hiển thị ảnh
        //        ptxImage.Image = Image.FromFile(destFile);
        //        ptxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileName(sourceFile);

                // Lấy đường dẫn thư mục Resources trong project
                string projectPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
                string resourcesFolder = Path.Combine(projectPath, "Resources");

                // Tạo thư mục Resources nếu chưa tồn tại
                //if (!Directory.Exists(resourcesFolder))
                //{
                //    Directory.CreateDirectory(resourcesFolder);
                //}

                // Copy ảnh vào thư mục Resources
                string destFile = Path.Combine(resourcesFolder, fileName);
                File.Copy(sourceFile, destFile, true);

                // Lưu đường dẫn tương đối (từ thư mục Resources)
                //path = Path.Combine("Resources", fileName);
                path = fileName;

                // Hiển thị ảnh đã upload lên PictureBox
                ptxImage.Image = Image.FromFile(destFile);
                ptxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}
