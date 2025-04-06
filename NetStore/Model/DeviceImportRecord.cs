using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class DeviceImportRecord
    {
        private int quantityImport;
        private double price;
        public DeviceImportRecord(int quantityImport, double price)
        {
            this.quantityImport = quantityImport;
            this.price = price;
        }
        public int QuantityImport
        {
            set { quantityImport = value; }
            get { return quantityImport; }
        }
        public double Price
        { 
            set { price = value; }
            get { return price; } 
        }
    }
}
