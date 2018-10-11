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

        public OrderDisplay RetrieveOrderDisplay(int OrderId)
        {
            var orderDisplay = new OrderDisplay();

            if (OrderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 10, 10, 00, 00, 00, new TimeSpan());
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bad End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };

                orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

                if (OrderId == 10)
                {
                    var orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2

                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                    orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6M,
                        OrderQuantity = 1

                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                }
            }

            return orderDisplay;

        }

        public bool Save()
        {
            return true;
        }
    }
}
