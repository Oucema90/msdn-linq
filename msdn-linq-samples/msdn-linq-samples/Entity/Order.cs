using System;

namespace msdn_linq_samples.Entity
{
    public class Order
    {
        public long OrderId;

        public DateTime OrderDate;

        public decimal Total;

        public Order(int orderId, DateTime date, decimal total)
        {
            OrderId = orderId;
            OrderDate = date;
            Total = total;
        }

        public override string ToString()
        {
            return $"OrderId={OrderId} Order Date={OrderDate} Total={Total}";
        }
    }
}
