using System;
using System.Collections.Generic;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Display
{
    public class Display
    {
        public static void DisplayInts(IEnumerable<int> ints)
        {
            foreach (var element in ints) Console.WriteLine(element);
        }

        public static void DisplayStrings(IEnumerable<string> strings)
        {
            foreach (var d in strings)
                Console.WriteLine("The word {0} is shorter than its value.", d);
        }

        public static void DisplayProducts(IEnumerable<Product> products, string sample)
        {
            switch (sample)
            {
                case "2":
                    foreach (var product in products) Console.WriteLine("{0} is sold out!", product.Name);
                    break;
                case "3":
                    foreach (var product in products)
                        Console.WriteLine("{0} is in stock and costs more than 3.00.", product.Name);
                    break;
                default:
                    Console.WriteLine("The sample {0} isns't a product sample", sample);
                    break;
            }
        }

        public static void DisplayCustomers(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer {0}: {1}", customer.CustomerId, customer.CompanyName);
                foreach (var order in customer.Orders)
                    Console.WriteLine("  Order {0}: {1}", order.OrderId, order.Date);
            }
        }

        public static void DisplayAbs(IEnumerable<AB> aBs)
        {
        }

        public static void DisplayDigitEvens(IEnumerable<DigitEven> digitEvens)
        {
        }

        public static void DisplayNumInPlaces(IEnumerable<NumInPlace> numInPlaces)
        {
        }

        public static void DisplayUpperLowers(IEnumerable<UpperLower> upperLowers)
        {
        }

        public static void DisplayCustomerOrders(IEnumerable<CustomerOrder> customerOrders)
        {
        }
    }
}
