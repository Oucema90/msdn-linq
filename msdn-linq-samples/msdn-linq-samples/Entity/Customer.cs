using System.Collections.Generic;

namespace msdn_linq_samples.Entity
{
    public class Customer
    {
        public long Id;

        public string CompanyName;

        public List<Order> Orders;

        public string Region;

        public Customer(long id,string companyName, string region, List<Order> orders)
        {
            Id = id;
            CompanyName = companyName;
            Region = region;
            Orders = orders;
        }
    }
}
