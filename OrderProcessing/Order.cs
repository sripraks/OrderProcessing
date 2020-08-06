using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessing
{
    public class Order
    {   
        public string ItemCode { get; set; }
        public int Qty { get; set; }
        //test
        public Order(string itemcode, int qty)
        {
            ItemCode = itemcode;
            Qty = qty;
        }
    }
}
