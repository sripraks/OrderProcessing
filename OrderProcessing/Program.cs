using System;
using Version = SemVer.Version;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            var semversion = new Version(1, 0, Int16.Parse(ThisAssembly.Git.SemVer.Patch)); 

            Order order = new Order("ITEM1", 100);
            OrderProvisingEngine ProcessOrder = new OrderProvisingEngine();
            ProcessOrder.OrderSubmitted += new EventHandler<OrderSubmittedEventArgs>(ProcessOrder_OrderSubmitted); 
            ProcessOrder.SubmitOrder(order);
            
        }

        static void ProcessOrder_OrderSubmitted(object sender, OrderSubmittedEventArgs e)
        {
            Console.WriteLine("Order Submitted after tag"+e.OrderNum);
            while (true)
            {
                Console.WriteLine("Order Status");
                break;
            }
            Console.ReadKey();
        }
    }
}
