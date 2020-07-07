using System;

namespace EventsDelegatesLamda
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
