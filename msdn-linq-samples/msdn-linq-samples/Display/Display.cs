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
            foreach (var ab in aBs)
            {
                Console.WriteLine("{0} is less than {1}", ab.A, ab.B);
            }
        }

        public static void DisplayDigitEvens(IEnumerable<DigitEven> digitEvens)
        {
            foreach (var de in digitEvens)
            {
                Console.WriteLine("The digit {0} is {1}.", de.Digit, de.Even ? "even" : "odd");
            }
        }

        public static void DisplayNumInPlaces(IEnumerable<NumInPlace> numInPlaces)
        {
            foreach (var nip in numInPlaces)
            {
                Console.WriteLine("{0}: {1}", nip.Num, nip.InPlace);
            }
        }

        public static void DisplayUpperLowers(IEnumerable<UpperLower> upperLowers)
        {
            foreach (var ul in upperLowers)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }

        public static void DisplayCustomerOrders(IEnumerable<CustomerOrder> customerOrders, int choice)
        {
            foreach (var customerOrder in customerOrders)
            {
                switch (choice)
                {
                    case 15:
                    case 17:
                        Console.WriteLine("CustomerID={0} OrderId={1} Total={2}",customerOrder.CustomerId,customerOrder.OrderId,customerOrder.Total);
                        break;
                    case 16:
                        Console.WriteLine("CustomerID={0} OrderId={1} OrderDate={2}",customerOrder.CustomerId,customerOrder.OrderId,customerOrder.Date);
                        break;
                    case 18:
                        Console.WriteLine("CustomerID={0} OrderId={1}",customerOrder.CustomerId,customerOrder.OrderId);
                        break;
                    default:
                        Console.WriteLine("\nNo such choice in the list");
                        break;
                }
            }
        }
    }
}
