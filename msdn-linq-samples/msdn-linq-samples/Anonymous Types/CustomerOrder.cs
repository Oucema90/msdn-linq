using System;

namespace msdn_linq_samples.Anonymous_Types
{
    public class CustomerOrder
    {
        public long CustomerId { get; set; }

        public long OrderId { get; set; }

        public decimal Total { get; set; }

        public DateTime Date { get; set; }
    }
}
