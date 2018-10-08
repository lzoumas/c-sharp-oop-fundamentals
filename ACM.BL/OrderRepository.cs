using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order();

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 10, 04, 16, 52, 00, new TimeSpan());
            }

            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
