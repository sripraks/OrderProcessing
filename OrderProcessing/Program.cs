using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order("ITEM1", 100);
            OrderProvisingEngine ProcessOrder = new OrderProvisingEngine();
            ProcessOrder.OrderSubmitted += new EventHandler<OrderSubmittedEventArgs>(ProcessOrder_OrderSubmitted); 
            ProcessOrder.SubmitOrder(order);
            
        }

        static void ProcessOrder_OrderSubmitted(object sender, OrderSubmittedEventArgs e)
        {
            Console.WriteLine("Order Submitted "+e.OrderNum);
            while (true)
            {
                Console.WriteLine("Order Status ffdd ee ff");
                break;
            }
            Console.ReadKey();
        }
    }
}
