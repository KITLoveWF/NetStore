using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class Inventory
    {
        private string nameInventory;
        private double sellingPrice;
        private int quantity;
        private string image;
        private string type;

        public Inventory(string nameInventory, int quantity)
        {
            this.nameInventory = nameInventory;
            this.quantity = quantity;
        }
        public string NameInventory 
        { 
            set { this.nameInventory = value; }
            get { return nameInventory; 
            } 
        }
        public double SellingPrice
        {
            set { this.sellingPrice = value; }
            get { return sellingPrice; }
        }
        public int Quantity
        { 
            set { this.quantity = value; }
            get { return quantity; } 
        }
        public string Image
        {
            set { this.image = value; }
            get { return image; }
        }
        public string Type
        { 
            set { this.type = value; }
            get { return type; } 
        }
    }
}
