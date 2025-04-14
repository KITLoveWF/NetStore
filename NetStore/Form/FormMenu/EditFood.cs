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
using System.Xml.Linq;

namespace NetStore.Form.FormMenu
{
    public partial class EditFood : System.Windows.Forms.Form
    {
        public string path;
        public EditFood()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            double sellingPrice = Convert.ToDouble(txtPrice.Text);
            string image = path;
            InventoryDAO inventoryDAO = new InventoryDAO();
            inventoryDAO.UpdateMenu2(sellingPrice, image,txtName.Text); 
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
