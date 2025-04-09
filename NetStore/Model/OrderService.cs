using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class OrderService
    {
        private int inventoryID;
        private int receiptID;
        private int quantityOrder;

        public OrderService(int inventoryID, int receiptID, int quantityOrder)
        {
            this.inventoryID = inventoryID;
            this.receiptID = receiptID;
            this.quantityOrder= quantityOrder;
        }
        public int InventoryID
        {  
            set { inventoryID = value; }
            get { return inventoryID; } }
        public int QuantityOrder
        { 
            set { quantityOrder = value; }
            get { return quantityOrder; } }
        public int ReceiptID
        { 
            set { receiptID = value; }
            get {  return receiptID; } }
    }
}
