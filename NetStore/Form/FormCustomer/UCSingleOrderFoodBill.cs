using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore.Form.FormCustomer
{
    public partial class UCSingleOrderFoodBill: UserControl
    {
        public event EventHandler<int> QuantityChanged; // int là delta: +1 hoặc -1
        public event EventHandler<int> ItemRemoved; // int: price để cập nhật lblTotal
        private int id;
        private int remainingQuantity;
        public void IncreaseQuantity()
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity < remainingQuantity)
            {
                quantity++;
                lblQuantity.Text = quantity.ToString();
            }
        }
        public UCSingleOrderFoodBill()
        {
            InitializeComponent();
        }
        public void SetRemainingQuantity(int quantity)
        {
            this.remainingQuantity = quantity;
        }
        public void SetFoodName(string name)
        {
            lblFoodName.Text = name; // Label hiển thị tên món
        }
        public string GetFoodName()
        {
            return lblFoodName.Text; // Label hiển thị tên món
        }
        public string GetQuantity()
        {
            return lblQuantity.Text; // Label hiển thị tên món
        }
        public void SetPrice(string price)
        {
            lblPrice.Text = price;
        }
        public string GetPrice()
        {
            return lblPrice.Text;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if(quantity < remainingQuantity)
            {
                quantity++;
                lblQuantity.Text = quantity.ToString();
                QuantityChanged?.Invoke(this, +1); // báo tăng
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                QuantityChanged?.Invoke(this, -1);
            }
            else if (quantity == 1)
            {
                // Khi giảm từ 1 xuống 0 => xóa
                string rawPrice = lblPrice.Text.Replace("VND", "").Replace(",", "").Trim();
                if (int.TryParse(rawPrice, out int price))
                {
                    ItemRemoved?.Invoke(this, price);
                }
            }

        }

    }
}
