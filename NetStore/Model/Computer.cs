using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    public class Computer
    {
        private int id;
        private string status;
        private double price;
        private string nameComputer;
        public Computer(string status, double price, string name)
        {
            this.status = status;
            this.price = price;
            this.nameComputer = name;
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
        public string NameComputer
        { 
            set { nameComputer = value; }
            get { return nameComputer; } 
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
    }
}
