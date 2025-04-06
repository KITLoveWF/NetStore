using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class OrderService
    {
        private string status;
        private int quantity;
        private string nameOrderService;

        public OrderService(string status, int quantity, string nameOrderService)
        {
            this.status = status;
            this.quantity = quantity;
            this.nameOrderService = nameOrderService;
        }
        public string Status {  
            set { status = value; }
            get { return status; } }
        public int Quantity { 
            set { quantity = value; }
            get { return quantity; } }
        public string NameOrderService { 
            set { nameOrderService = value; }
            get {  return nameOrderService; } }
    }
}
