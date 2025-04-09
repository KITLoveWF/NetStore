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
    public partial class UCSingleFood: UserControl
    {
        public event EventHandler FoodClicked;
        private int id;
        private int quantity;

        public UCSingleFood()
        {
            InitializeComponent();
            // Gán sự kiện Click cho tất cả các control con
            this.Click += UCSingleFood_Click;
            guna2Panel1.Click += UCSingleFood_Click;
            guna2Panel2.Click += UCSingleFood_Click;
            pictureBox1.Click += UCSingleFood_Click;
            lblName.Click += UCSingleFood_Click;
            lblPrice.Click += UCSingleFood_Click;
        }
        private void UCSingleFood_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện ra bên ngoài
            if (FoodClicked != null)
            {
                FoodClicked(this, e);
            }
        }
        public void SetQuantity(int quantity)
        {
            this.quantity=quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }

        public void SetName(string name)
        {
            lblName.Text = name;
        }
        public string GetFoodName()
        {
            return lblName.Text;
        }
        public void SetPrice(string price)
        {
            if (decimal.TryParse(price, out decimal d))
            {
                int p = (int)d; // Ép về int nếu không cần phần thập phân
                lblPrice.Text = $"{p:N0} VND"; // Ví dụ: 30000.00 => "30,000 VND"
            }
            else
            {
                lblPrice.Text = price; // fallback nếu parse fail
            }
        }

        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }
        public string GetPrice()
        {
            return lblPrice.Text;
        }


    }
}
