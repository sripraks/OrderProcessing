using System;

namespace EventsDelegatesLamda
{
    public class OrderProvisingEngine
    {
        public event EventHandler<OrderSubmittedEventArgs> OrderSubmitted;

        public void SubmitOrder(Order order)
        {
            //Mimic to Store the order into the DB
            System.Threading.Thread.Sleep(1000);
            Random RndOrderNum = new Random();
            int ordernum = RndOrderNum.Next(1, 500);
            OrderSubmittedEventArgs e = new OrderSubmittedEventArgs(ordernum);
            OnOrderSubmitted(e);
        }

       protected virtual void OnOrderSubmitted(OrderSubmittedEventArgs e)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(this, e);
            }
        }
    }
}