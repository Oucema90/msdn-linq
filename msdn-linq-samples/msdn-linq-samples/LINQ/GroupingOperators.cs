using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;
using msdn_linq_samples.Utıils;

namespace msdn_linq_samples.LINQ
{
    public class GroupingOperators
    {
        #region Simples

        public IEnumerable<RemainderNumbers> Simple40()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.GroupBy(x => x % 5).Select(x => new RemainderNumbers { Remainder = x.Key, Numbers = x });
        }

        public IEnumerable<FirstLetterWords> Simple41()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            return words.GroupBy(x => x[0]).Select(x => new FirstLetterWords { FirstLetter = x.Key, Words = x });
        }

        public IEnumerable<CategoryProducts> Simple42()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts { Category = x.Key, Products = x });
        }

        public IEnumerable<CompanyNameYearsGroup> Simple43()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.Select(c => new CompanyNameYearsGroup
            {
                CompanyName = c.CompanyName,
                YearGrouping = c.Orders.GroupBy(o => o.OrderDate.Year).Select(yg => new YearGroups
                {
                    Year = yg.Key,
                    MonthGrouping = yg.GroupBy(o => o.OrderDate.Month).Select(mg => new MonthGroups
                    {
                        Month = mg.Key,
                        Orders = mg
                    })
                })
            });

        }

        public IEnumerable<IGrouping<string, string>> Simple44()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            return anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
        }

        public IEnumerable<IGrouping<string, string>> Simple45()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            return anagrams.GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer());
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nGrouping Operators");
            Console.WriteLine();
            for (var i = 1; i <= 6; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 39);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunGroupingOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nModulo 5 grouing:");
                        Display.Display.DisplayRemainderNumbers(Simple40());
                        break;
                    case "2":
                        Console.WriteLine("\nFirst letter grouping:");
                        Display.Display.DisplayFirstLetterWords(Simple41());
                        break;
                    case "3":
                        Console.WriteLine("\nCategory products grouping:");
                        Display.Display.DisplayCategoryProducts(Simple42(),-1);
                        break;
                    case "4":
                        Console.WriteLine("\nCompany products grouping:");
                        Display.Display.DisplayCompnayNameYearsGroups(Simple43());
                        break;
                    case "5":
                        Console.WriteLine("\nAnagram grouping:");
                        Display.Display.DisplayGroupingStringString(Simple44());
                        break;
                    case "6":
                        Console.WriteLine("\nAnagram grouping:");
                        Display.Display.DisplayGroupingStringString(Simple45());
                        break;
                    default:
                        Console.WriteLine(cki.Key == ConsoleKey.Escape
                            ? "\nGoing back to Main Menu"
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
