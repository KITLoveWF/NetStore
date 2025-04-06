using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class Computer
    {
        private string status;
        private double price;
        private int quantity;
        public Computer(string status, double price, int quantity)
        {
            this.status = status;
            this.price = price;
            this.quantity = quantity;
        }
        public string Status
        { 
            set { status = value; }
            get { return status; } 
        }
        public double Price
        { 
            set { price = value; }
            get { return price; } 
        }
        public int Quantity
        { 
            set { quantity = value; }
            get { return quantity; } 
        }
    }
}
