using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; } // nullable value type, tracks the date/time/timezone offset

        public List<OrderItem> OrderItems { get; set; } // compositional relationship

        public int OrderId { get; private set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return $"{OrderDate} ({OrderId})";
        }

    }
}
