using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Enums;

namespace msdn_linq_samples.Provider
{
    public class DataProvider
    {
        public static IEnumerable<Customer> GetCustomersList()
        {
            return new List<Customer>
            {
                new Customer(1, "Lazy K Kountry Store", "WA", GetOrderList(1).ToList()),
                new Customer(2, "Trail's Head Gourmet Provisioners", "WA", GetOrderList(2).ToList()),
                new Customer(3, "White Clover Markets", "WA", GetOrderList(3).ToList()),
                new Customer(4, "Haci Sait", "IS", GetOrderList(4).ToList()),
                new Customer(5, "Baguette", "PA", GetOrderList(5).ToList()),
                new Customer(6, "Meublatex", "TU", GetOrderList(6).ToList())
            };
        }

        public static IEnumerable<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product("Chef Anton\'s Gumbo Mix", 0, 2M, "Food"),
                new Product("Alice Mutton", 0, 7M, "Perfum"),
                new Product("Thringer", 0, 6M, "Electronıc"),
                new Product("Gorgonzola", 0, 3M, "Movie"),
                new Product("Perth Pasties", 0, 1M, "Food"),
                new Product("Chai", 3, 4M, "Perfum"),
                new Product("Chang", 4, 5M, "Perfum"),
                new Product("Aniseed Syrup", 3, 7M, "Medecine"),
                new Product("Northwoods Cranberry Sauce", 2, 9M, "Food"),
                new Product("Mishi Kobe Niku", 1, 11M, "Movie")
            };
        }

        public static IEnumerable<Order> GetOrderList(int id)
        {
            switch (id)
            {
                case 1:
                    return new List<Order>
                    {
                        new Order(10482, new DateTime(1997, 3, 21, 12, 0, 0), 152.0M),
                        new Order(10545, new DateTime(1997, 5, 22, 12, 0, 0), 153.0M)
                    };
                case 2:
                    return new List<Order>
                    {
                        new Order(10574, new DateTime(1997, 6, 19, 12, 0, 0), 254.0M),
                        new Order(10545, new DateTime(1997, 6, 23, 12, 0, 0), 56.0M)
                    };
                case 3:
                    return new List<Order>
                    {
                        new Order(10269, new DateTime(1998, 8, 1, 12, 0, 0), 155.0M),
                        new Order(10545, new DateTime(1996, 7, 31, 12, 0, 0), 352.0M)
                    };
                case 4:
                    return new List<Order>
                    {
                        new Order(10469, new DateTime(1997, 3, 21, 12, 0, 0), 852.0M),
                        new Order(10483, new DateTime(1997, 5, 22, 12, 0, 0), 652.0M)
                    };
                default:
                    return new List<Order>();
            }
        }

        public static IEnumerable<int> GetNumberList()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers;
        }

        public static IEnumerable<LinqOperators> GetLinqOperators()
        {
            return new List<LinqOperators>
            {
                LinqOperators.Restriction,
                LinqOperators.Projection,
                LinqOperators.Partition,
                LinqOperators.Ordering,
                LinqOperators.Grouping,
                LinqOperators.Set,
                LinqOperators.Conversion,
                LinqOperators.Element,
                LinqOperators.Generation,
                LinqOperators.Quantifier,
                LinqOperators.Aggregate,
                LinqOperators.Miscellaneous,
                LinqOperators.QueryExecution,
                LinqOperators.Join
            };
        }
    }
}
