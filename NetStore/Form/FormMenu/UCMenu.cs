using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.FormMenu
{
    public partial class UCMenu: UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
            ConfigureFlowPanel();
        }

        private void ConfigureFlowPanel()
        {
            flowcom.AutoSize = false; // Ngăn flowcom thay đổi kích thước
            flowcom.Padding = new Padding(5); // Khoảng cách giữa các ItemFood
            flowcom.AutoScroll = true; // Bật cuộn nếu có quá nhiều item
        }

        public void AddItem(ItemFood item)
        {
            item.Size = new Size(385, 154); // Giữ kích thước cố định
            item.MinimumSize = new Size(385, 154);
            item.MaximumSize = new Size(385, 154);
            item.Margin = new Padding(5); // Khoảng cách giữa các ItemFood

            flowcom.Controls.Add(item);
        }
    }
}
