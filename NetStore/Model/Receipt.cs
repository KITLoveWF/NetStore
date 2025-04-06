using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class Receipt
    {
        private double serviceCost;
        private double computerCost;
        private double totalPrice;
        private DateTime timeBegin;
        private DateTime timeEnd;
        public Receipt(double serviceCost, double computerCost, double totalPrice, DateTime timeBegin, DateTime timeEnd)
        {
            this.serviceCost = serviceCost;
            this.computerCost = computerCost;
            this.totalPrice = totalPrice;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
        }
        public double ServiceCost { 
            set { serviceCost = value; }
            get {  return serviceCost; } }
        public double ComputerCost
        {
            set { computerCost = value; }
            get { return computerCost; }
        }
        public double TotalPrice
        {
            set { totalPrice = value; }
            get { return totalPrice; }
        }
        public DateTime TimeBegin
        {
            set { timeBegin = value; }
            get { return timeBegin; }
        }
        public DateTime TimeEnd
        {
            set { timeEnd = value; }
            get { return timeEnd; }
        }
    }
}
