using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        private OrderLogger orderLogger = new OrderLogger();
        private OrderNotifier orderNotifier = new OrderNotifier();
        public void AddOrder(Order order)
        {

           orders.Add(order);
           orderLogger.LogOrder(order);
           orderNotifier.NotifyCustomer(order);

        }

     

     
    }



    public class OrderLogger
    {
        public void LogOrder(Order order)
        {

            //Log the order to a file

            Console.WriteLine($"Order {order.Id} logged.");


        }

    }
    public class OrderNotifier
    {
        public void NotifyCustomer(Order order)
        {

            //sent a notification to the costumer
            Console.WriteLine($"Custimer notified for order {order.Id}");

        }
    }
 }
