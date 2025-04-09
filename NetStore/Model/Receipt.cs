using System;

namespace NetStore.Model
{
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public int ComputerID { get; set; }
        public int CustomerID { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal ComputerCost { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }  // Nullable để kiểm tra phiên chưa kết thúc

        // Constructor đầy đủ
        public Receipt(int receiptID, int computerID, int customerID, decimal serviceCost, decimal computerCost, decimal totalPrice, DateTime timeBegin, DateTime? timeEnd)
        {
            ReceiptID = receiptID;
            ComputerID = computerID;
            CustomerID = customerID;
            ServiceCost = serviceCost;
            ComputerCost = computerCost;
            TotalPrice = totalPrice;
            TimeBegin = timeBegin;
            TimeEnd = timeEnd;
        }

        // Constructor cơ bản khi chỉ có ID + thời gian
        public Receipt(int receiptID, int computerID, int customerID, DateTime timeBegin, DateTime? timeEnd)
        {
            ReceiptID = receiptID;
            ComputerID = computerID;
            CustomerID = customerID;
            TimeBegin = timeBegin;
            TimeEnd = timeEnd;
        }

        // Constructor cơ bản khi vừa add
        public Receipt(int computerID, int customerID, DateTime timeBegin)
        {
            ComputerID = computerID;
            CustomerID = customerID;
            TimeBegin = timeBegin;
        }

        //// Constructor đơn giản nếu chỉ có chi phí
        //public Receipt(decimal serviceCost, decimal computerCost, decimal totalPrice, DateTime timeBegin, DateTime? timeEnd)
        //{
        //    ServiceCost = serviceCost;
        //    ComputerCost = computerCost;
        //    TotalPrice = totalPrice;
        //    TimeBegin = timeBegin;
        //    TimeEnd = timeEnd;
        //}

        // Constructor mặc định
        public Receipt() { }
    }
}
