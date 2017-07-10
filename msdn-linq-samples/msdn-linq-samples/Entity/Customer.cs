using System.Collections.Generic;

namespace msdn_linq_samples.Entity
{
    public class Customer
    {
        public long CustomerId;

        public string CompanyName;

        public List<Order> Orders;

        public string Region;

        public Customer(long customerId, string companyName, string region, List<Order> orders)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            Region = region;
            Orders = orders;
        }
    }
}
