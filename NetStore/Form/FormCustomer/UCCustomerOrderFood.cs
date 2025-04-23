using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetStore.Form.FormCustomer;
using NetStore.Model;

namespace NetStore.Form
{
    public partial class UCCustomerOrderFood: UserControl
    {
        OrderServiceDAO orderServiceDAO = new OrderServiceDAO();
        private NetStore.Model.Customer customer;
        private NetStore.Model.Receipt receipt;

        public void SetCustomer(NetStore.Model.Customer customer)
        {
            this.customer = customer;
        }
        public void SetReceipt(NetStore.Model.Receipt receipt)
        {
            this.receipt = receipt;
        }
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
            flpRice.Controls.Clear(); // Xóa các UC cũ (nếu có)

            DataTable dtRice = inventoryDAO.GetInventoriesByType("Rice");
            DataTable dtDrink = inventoryDAO.GetInventoriesByType("Drink");
            DataTable dtNoodle = inventoryDAO.GetInventoriesByType("Noodle");
            DataTable dtCard = inventoryDAO.GetInventoriesByType("Card");

            foreach (DataRow row in dtRice.Rows)
            {
                UCSingleFood food = new UCSingleFood();
                food.Size = new Size(112, 52);
                string name = row["nameInventory"].ToString();
                string price = row["sellingPrice"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                int id = Convert.ToInt32(row["inventoryID"]);
                food.SetID(id);
                food.SetName(name);
                food.FoodClicked += Food_FoodClicked;
                food.SetPrice(price);
                food.SetQuantity(quantity);

                flpRice.Controls.Add(food);
            }
            foreach (DataRow row in dtDrink.Rows)
            {
                UCSingleFood food = new UCSingleFood();
                food.Size = new Size(145, 60);

                string name = row["nameInventory"].ToString();
                string price = row["sellingPrice"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                int id = Convert.ToInt32(row["inventoryID"]);
                food.SetID(id);
                food.SetName(name);
                food.FoodClicked += Food_FoodClicked;
                food.SetPrice(price);
                food.SetQuantity(quantity);

                flpDrink.Controls.Add(food);
            }
            foreach (DataRow row in dtNoodle.Rows)
            {
                UCSingleFood food = new UCSingleFood();
                food.Size = new Size(145, 60);

                string name = row["nameInventory"].ToString();
                string price = row["sellingPrice"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                int id = Convert.ToInt32(row["inventoryID"]);
                food.SetID(id);
                food.SetName(name);
                food.FoodClicked += Food_FoodClicked;
                food.SetPrice(price);
                food.SetQuantity(quantity);

                flpNoodle.Controls.Add(food);
            }
            foreach (DataRow row in dtCard.Rows)
            {
                UCSingleFood food = new UCSingleFood();
                food.Size = new Size(145, 60);

                string name = row["nameInventory"].ToString();
                string price = row["sellingPrice"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                int id = Convert.ToInt32(row["inventoryID"]);
                food.SetID(id);
                food.SetName(name);
                food.FoodClicked += Food_FoodClicked;
                food.SetPrice(price);
                food.SetQuantity(quantity);

                flpCard.Controls.Add(food);
            }
        }
        //private void Food_FoodClicked(object sender, EventArgs e)
        //{
        //    UCSingleFood clickedFood = sender as UCSingleFood;
        //    if (clickedFood != null)
        //    {
        //        int id = clickedFood.GetID();
        //        int quantity = clickedFood.GetQuantity();
        //        string foodName = clickedFood.GetFoodName();

        //        // Lấy giá và xử lý định dạng từ UCSingleFood
        //        string rawPrice = clickedFood.GetPrice();
        //        string cleanedPrice = rawPrice.Replace("VND", "").Replace(",", "").Trim();

        //        int price = int.Parse(cleanedPrice);

        //        // Lấy giá trị hiện tại từ lblTotal
        //        string currentText = lblTotal.Text.Replace("VND", "").Replace(",", "").Trim();
        //        int currentTotal = 0;

        //        // Nếu lblTotal có giá trị, parse ra số
        //        if (!string.IsNullOrEmpty(currentText))
        //        {
        //            int.TryParse(currentText, out currentTotal);
        //        }

        //        // Tính tổng mới
        //        int newTotal = currentTotal + price;

        //        // Gán lại lblTotal với định dạng đẹp
        //        lblTotal.Text = $"{newTotal:N0} VND"; // Ví dụ: 100000 => "100,000 VND"

        //        // Thêm item vào hóa đơn
        //        UCSingleOrderFoodBill billItem = new UCSingleOrderFoodBill();
        //        billItem.SetFoodName(foodName); // Có thể truyền thêm giá, id,...
        //        billItem.SetPrice(rawPrice);
        //        billItem.SetID(id);
        //        billItem.SetRemainingQuantity(quantity);
        //        billItem.QuantityChanged += BillItem_QuantityChanged;
        //        billItem.ItemRemoved += BillItem_ItemRemoved;

        //        flpBill.Controls.Add(billItem);
        //    }
        //}
        private void Food_FoodClicked(object sender, EventArgs e)
        {
            UCSingleFood clickedFood = sender as UCSingleFood;
            if (clickedFood != null)
            {
                int id = clickedFood.GetID();
                int quantity = clickedFood.GetQuantity();
                string foodName = clickedFood.GetFoodName();

                string rawPrice = clickedFood.GetPrice();
                string cleanedPrice = rawPrice.Replace("VND", "").Replace(",", "").Trim();
                int price = int.Parse(cleanedPrice);

                // Tìm xem món ăn đã có trong flpBill chưa
                foreach (Control control in flpBill.Controls)
                {
                    if (control is UCSingleOrderFoodBill existingBillItem && existingBillItem.GetID() == id)
                    {
                        // Nếu đã có món này, tăng số lượng
                        existingBillItem.IncreaseQuantity(); // hoặc existingBillItem.AddQuantity(1);
                                               // Cập nhật tổng tiền
                        string currentText = lblTotal.Text.Replace("VND", "").Replace(",", "").Trim();
                        int currentTotal = string.IsNullOrEmpty(currentText) ? 0 : int.Parse(currentText);
                        int newTotal = currentTotal + price;
                        lblTotal.Text = $"{newTotal:N0} VND";

                        return; // Thoát khỏi hàm, không thêm mới
                    }
                }

                // Nếu chưa có món này trong flpBill => thêm mới
                UCSingleOrderFoodBill billItem = new UCSingleOrderFoodBill();
                billItem.SetFoodName(foodName);
                billItem.SetPrice(rawPrice);
                billItem.SetID(id);
                billItem.SetRemainingQuantity(quantity);
                billItem.QuantityChanged += BillItem_QuantityChanged;
                billItem.ItemRemoved += BillItem_ItemRemoved;

                flpBill.Controls.Add(billItem);

                // Cập nhật tổng tiền
                string totalText = lblTotal.Text.Replace("VND", "").Replace(",", "").Trim();
                int currentTotalAdd = string.IsNullOrEmpty(totalText) ? 0 : int.Parse(totalText);
                int newTotalAdd = currentTotalAdd + price;
                lblTotal.Text = $"{newTotalAdd:N0} VND";
            }
        }

        //public void IncreaseQuantity(int amount)
        //{
        //    int currentQuantity = int.Parse(lblQuantity.Text); // hoặc cách bạn lưu quantity
        //    int newQuantity = currentQuantity + amount;
        //    lblQuantity.Text = newQuantity.ToString();

        //    // Có thể kích hoạt sự kiện QuantityChanged nếu cần cập nhật tổng tiền:
        //    QuantityChanged?.Invoke(this, amount);
        //}

        private void BillItem_QuantityChanged(object sender, int delta)
        {
            UCSingleOrderFoodBill billItem = sender as UCSingleOrderFoodBill;
            if (billItem != null)
            {
                // Lấy giá món ăn từ lblPrice (VD: "10,000 VND")
                string rawPrice = billItem.GetPrice().Replace("VND", "").Replace(",", "").Trim();
                int price = int.Parse(rawPrice);

                // Lấy tổng hiện tại
                string currentTotalText = lblTotal.Text.Replace("VND", "").Replace(",", "").Trim();
                int currentTotal = int.Parse(currentTotalText);

                // Tính lại tổng
                int newTotal = currentTotal + (price * delta);

                // Gán lại lblTotal với định dạng
                lblTotal.Text = $"{newTotal:N0} VND";
            }
        }
        private void BillItem_ItemRemoved(object sender, int price)
        {
            UCSingleOrderFoodBill billItem = sender as UCSingleOrderFoodBill;
            if (billItem != null)
            {
                flpBill.Controls.Remove(billItem); // Xóa khỏi FlowLayoutPanel

                // Cập nhật lblTotal
                string currentText = lblTotal.Text.Replace("VND", "").Replace(",", "").Trim();
                int currentTotal = int.Parse(currentText);

                int newTotal = currentTotal - price;
                if (newTotal < 0) newTotal = 0;

                lblTotal.Text = $"{newTotal:N0} VND";
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (flpBill.Controls.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn món nào để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string totalText = lblTotal.Text.Trim();

            DialogResult result = MessageBox.Show(
                $"Tổng số tiền cần thanh toán: {totalText}\n\nBạn có muốn xác nhận đặt món không?",
                "Xác nhận đặt món",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                foreach (Control control in flpBill.Controls)
                {
                    if (control is UCSingleOrderFoodBill billItem)
                    {
                        int inventoryID = billItem.GetID();           // Giả sử bạn có phương thức GetID()
                        string quantityOrder = billItem.GetQuantity();   // Giả sử bạn có phương thức GetQuantity()

                        // Test: In ra thông tin
                        //Console.WriteLine($"InventoryID: {inventoryID}, Quantity: {quantityOrder}, ReceiptID: {receiptID}");
                        OrderService orderService = new OrderService(inventoryID, receipt.ReceiptID, int.Parse(quantityOrder));
                        orderServiceDAO.AddOrderService(orderService);
                        // Bạn có thể thực hiện logic insert vào DB ở đây nếu muốn
                    }
                }                
                // Xóa hết món trong flpBill
                flpBill.Controls.Clear();

                // Reset tổng tiền
                lblTotal.Text = "0 VND";


                MessageBox.Show("Đặt món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



    }
}
