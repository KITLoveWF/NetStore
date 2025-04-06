using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class Device
    {
        private string nameDevice;
        private int quantity;
        public Device(string nameDevice, int quantity)
        {
            this.nameDevice = nameDevice;
            this.quantity = quantity;
        }
        public string NameDevice
        {
            set { nameDevice = value; }
            get { return nameDevice; }
        }
        public int Quantity
        { 
            set { quantity = value; }
            get { return quantity; } 
        }

    }
}
