using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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

        public static void DisplayStrings(IEnumerable<string> strings, int value)
        {
            if(value == 1)
                foreach (var d in strings)
                    Console.WriteLine(d);
            else
            {
                foreach (var d in strings)
                    Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }

        public static void DisplayProducts(IEnumerable<Product> products, string sample)
        {
            switch (sample)
            {
                case "2":
                    foreach (var product in products)
                        Console.WriteLine("{0} is sold out!", product.ProductName);
                    break;
                case "3":
                    foreach (var product in products)
                        Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
                    break;
                case "4":
                    foreach (var product in products)
                        Console.WriteLine(product.ToString());
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
                    Console.WriteLine("  Order {0}: {1}", order.OrderId, order.OrderDate);
            }
        }

        public static void DisplayAbs(IEnumerable<AB> aBs)
        {
            foreach (var ab in aBs)
                Console.WriteLine("{0} is less than {1}", ab.A, ab.B);
        }

        public static void DisplayDigitEvens(IEnumerable<DigitEven> digitEvens)
        {
            foreach (var de in digitEvens)
                Console.WriteLine("The digit {0} is {1}.", de.Digit, de.Even ? "even" : "odd");
        }

        public static void DisplayNumInPlaces(IEnumerable<NumInPlace> numInPlaces)
        {
            foreach (var nip in numInPlaces)
                Console.WriteLine("{0}: {1}", nip.Num, nip.InPlace);
        }

        public static void DisplayUpperLowers(IEnumerable<UpperLower> upperLowers)
        {
            foreach (var ul in upperLowers)
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
        }

        public static void DisplayCustomerOrders(IEnumerable<CustomerOrder> customerOrders, int choice)
        {
            foreach (var customerOrder in customerOrders)
                switch (choice)
                {
                    case 15:
                    case 17:
                        Console.WriteLine("CustomerID={0} OrderId={1} Total={2}", customerOrder.CustomerId,
                            customerOrder.OrderId, customerOrder.Total);
                        break;
                    case 16:
                        Console.WriteLine("CustomerID={0} OrderId={1} OrderDate={2}", customerOrder.CustomerId,
                            customerOrder.OrderId, customerOrder.Date);
                        break;
                    case 18:
                        Console.WriteLine("CustomerID={0} OrderId={1}", customerOrder.CustomerId,
                            customerOrder.OrderId);
                        break;
                    default:
                        Console.WriteLine("\nNo such choice in the list");
                        break;
                }
        }

        public static void DisplayDoubles(IEnumerable<double> doubles)
        {
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
            }
        }

        public static void DisplayRemainderNumbers(IEnumerable<RemainderNumbers> reminderNumbers)
        {
            foreach (var reminderNumber in reminderNumbers)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", reminderNumber.Remainder);
                foreach (var number in reminderNumber.Numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void DisplayFirstLetterWords(IEnumerable<FirstLetterWords> firstLetterWords)
        {
            foreach (var firstLetterWord in firstLetterWords)
            {
                Console.WriteLine("Words that start with the letter '{0}':", firstLetterWord.FirstLetter);
                foreach (var word in firstLetterWord.Words)
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void DisplayCategoryProducts(IEnumerable<CategoryProducts> categoryProducts,int value)
        {
            foreach (var categoryProduct in categoryProducts)
            {
                Console.WriteLine($"Category =   {categoryProduct.Category}");
                switch (value)
                {
                    case 1:
                        Console.WriteLine($"Total Products    =   {categoryProduct.ProductCount}");
                        break;
                    case 2:
                        Console.WriteLine($"Total units in stock    = {categoryProduct.TotalUnitsInStock}");
                        break;
                    case 3:
                        Console.WriteLine($"Cheapest price  =   {categoryProduct.CheapestPrice}");
                        break;
                    case 4:
                        Console.WriteLine("Cheapest products");
                        foreach (var product in categoryProduct.CheapestProducts)
                        {
                            Console.WriteLine(product.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Most expensive price  =   {categoryProduct.MostExpensivePrice}");
                        break;
                    case 6:
                        Console.WriteLine("Most expensive products");
                        foreach (var product in categoryProduct.MostExpensiveProducts)
                        {
                            Console.WriteLine(product.ToString());
                        }
                        break;
                    case 7:
                        Console.WriteLine($"Average price  =   {categoryProduct.AveragePrice}");
                        break;
                    default:
                        foreach (var product in categoryProduct.Products)
                        {
                            Console.WriteLine(product.ToString());
                        }
                        break;
                }
                    
            }
        }

        public static void DisplayCompnayNameYearsGroups(IEnumerable<CompanyNameYearsGroup> compnayNameYearsGroups)
        {
            foreach (var compnayNameYearsGroup in compnayNameYearsGroups)
            {
                Console.WriteLine("Company Name={0} ...", compnayNameYearsGroup.CompanyName);
                foreach (var yearGrouping in compnayNameYearsGroup.YearGrouping)
                {
                    Console.WriteLine("YearGroups={0}", yearGrouping.Year);
                    foreach (var monthGrouping in yearGrouping.MonthGrouping)
                    {
                        Console.WriteLine("MonthGroups={0}", monthGrouping.Month);
                        foreach (var order in monthGrouping.Orders)
                        {
                            Console.WriteLine(order.ToString());
                        }
                    }
                }
            }
        }

        public static void DisplayGroupingStringString(IEnumerable<IGrouping<string, string>> stringStringGrouping)
        {
            foreach (var group in stringStringGrouping)
            {
                Console.WriteLine("...");
                foreach (var g in group)
                {
                    Console.WriteLine(g);
                }
            }
        }

        public static void DisplayChars(IEnumerable<char> chars)
        {
            foreach (var c in chars)
            {
                Console.WriteLine(c);
            }
        }

        public static void DisplayScoreRecords(IDictionary<string,ScoreRecord> scoreRecords)
        {
            foreach (var scoreRecord in scoreRecords)
            {
                Console.WriteLine($"Name:{scoreRecord.Key}  |   Score:{scoreRecord.Value.Score}");
            }
        }

        public static void DisplayCustomerOrderCount(IEnumerable<CustomerOrderCount> customerOrderCounts)
        {
            foreach (var customerOrderCount in customerOrderCounts)
            {
                Console.WriteLine($"CustomerID={customerOrderCount.CustomerId}  |   OrderCount={customerOrderCount.OrderCount}");
            }
        }
    }
}
