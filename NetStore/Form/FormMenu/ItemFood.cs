using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetStore.Form.FormMenu
{
    public partial class ItemFood: UserControl
    {
        public string path;
        public ItemFood()
        {
            InitializeComponent();
            //this.Size = new Size(385, 154);
            //this.MinimumSize = new Size(385, 154);
            //this.MaximumSize = new Size(385, 154);
            //this.AutoSize = false;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.Dock = DockStyle.None;
            //this.Anchor = AnchorStyles.None; // Đảm bảo không bị kéo giãn trong FlowLayoutPanel

            ptxBox.Size = new Size(80, 80);
            ptxBox.Location = new Point(10, 10);
            ptxBox.SizeMode = PictureBoxSizeMode.Zoom;

            //itemname.AutoSize = true;
            //itemname.Location = new Point(100, 20);


            //itemprice.AutoSize = true;
            //itemprice.Location = new Point(100, 50);

        }

        private void ItemFood_Load(object sender, EventArgs e)
        {

        }
    }
}
