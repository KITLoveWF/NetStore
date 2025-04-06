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
        private double priceImport;
        private double priceSelling;
        private int quantity;
        private string image;
        private string type;

        public Inventory(string nameInventory, double priceImport, double priceSelling, int quantity, string image, string type)
        {
            this.nameInventory = nameInventory;
            this.priceImport = priceImport;
            this.priceSelling = priceSelling;
            this.quantity = quantity;
            this.image = image;
            this.type = type;
        }
        public string NameInventory 
        { 
            set { this.nameInventory = value; }
            get { return nameInventory; 
            } 
        }
        public double PriceImport
        {
            set { this.priceImport = value; }
            get { return priceImport; }
        }
        public double PriceSelling
        {
            set { this.priceSelling = value; }
            get { return priceSelling; }
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
