using System;

namespace msdn_linq_samples.Entity
{
    public class Order
    {
        public long OrderId;

        public DateTime Date;

        public decimal Total;

        public Order(int orderId, DateTime date, decimal total)
        {
            OrderId = orderId;
            Date = date;
            Total = total;
        }
    }
}
