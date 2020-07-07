using System;

namespace EventsDelegatesLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order("ITEM1", 100);
            OrderProvisingEngine ProcessOrder = new OrderProvisingEngine();
            ProcessOrder.OrderSubmitted += new EventHandler<OrderSubmittedEventArgs>(ProcessOrder_OrderSubmitted); 
            ProcessOrder.SubmitOrder(order);
            Console.ReadKey();
        }

        static void ProcessOrder_OrderSubmitted(object sender, OrderSubmittedEventArgs e)
        {
            Console.WriteLine("Order Submitted For Reeleasse2 "+e.OrderNum);
            Console.ReadLine();
        }
    }
}
