using System;

namespace OrderProcessing
{
    public class OrderSubmittedEventArgs : EventArgs
    {
        public OrderSubmittedEventArgs(int ordernum)
        {
            OrderNum = ordernum;
        }
        public int OrderNum { get; set; }

    }
}
