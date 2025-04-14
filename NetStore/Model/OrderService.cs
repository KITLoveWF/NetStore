using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class OrderService
    {
       
        private string nameOrderService;
        private int quantity;
        private double price;

        public OrderService(double price, int quantity, string nameOrderService)
        {
            this.price = price;
            this.quantity = quantity;
            this.nameOrderService = nameOrderService;
        }
        public double Price {  
            set { price = value; }
            get { return price; } }
        public int Quantity { 
            set { quantity = value; }
            get { return quantity; } }
        public string NameOrderService { 
            set { nameOrderService = value; }
            get {  return nameOrderService; } }
    }
}
