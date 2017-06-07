using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Utils
{
    public class RestrictionOperatorsUtils
    {
        public static IEnumerable<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product("Chef Anton\'s Gumbo Mix", 0, 2M),
                new Product("Alice Mutton", 0, 7M),
                new Product("Thringer", 0, 6M),
                new Product("Gorgonzola", 0, 3M),
                new Product("Perth Pasties", 0, 1M),
                new Product("Chai", 3, 4M),
                new Product("Chang", 4, 5M),
                new Product("Aniseed Syrup", 3, 7M),
                new Product("Northwoods Cranberry Sauce", 2, 9M),
                new Product("Mishi Kobe Niku", 1, 11M),
            };
            
        }

        public static IEnumerable<Order> GetOrderList(int id)
        {
            switch (id)
            {
                case 1:
                    return new List<Order>()
                    {
                        new Order(10482, new DateTime(1997, 3, 21, 12, 0, 0)),
                        new Order(10545, new DateTime(1997, 22, 5, 12, 0, 0))
                    };
                case 2:
                    return new List<Order>()
                    {
                        new Order(10574, new DateTime(1997, 6, 19, 12, 0, 0)),
                        new Order(10545, new DateTime(1997, 23, 6, 12, 0, 0))
                    };
                case 3:
                    return new List<Order>()
                    {
                        new Order(10269, new DateTime(1998, 8, 1, 12, 0, 0)),
                        new Order(10545, new DateTime(1996, 31, 7, 12, 0, 0))
                    };
                case 4:
                    return new List<Order>()
                    {
                        new Order(10469, new DateTime(1997, 3, 21, 12, 0, 0)),
                        new Order(10483, new DateTime(1997, 5, 22, 12, 0, 0))
                    };
                default:
                    return new List<Order>();
            }
        }

        public static IEnumerable<Customer> GetCustomersList()
        {
            return new List<Customer>()
            {
                new Customer(1,"Lazy K Kountry Store","WA",GetOrderList(1).ToList()),
                new Customer(2,"Trail's Head Gourmet Provisioners","WA",GetOrderList(2).ToList()),
                new Customer(3,"White Clover Markets","WA",GetOrderList(3).ToList()),
                new Customer(4,"Haci Sait","IS",GetOrderList(4).ToList()),
                new Customer(5,"Baguette","PA",GetOrderList(5).ToList()),
                new Customer(6,"Meublatex","TU",GetOrderList(6).ToList()),
            };
        }
    }
}
