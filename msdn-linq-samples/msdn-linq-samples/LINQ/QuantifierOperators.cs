using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class QuantifierOperators
    {
        #region Simples

        public bool Simple67()
        {
            string[] words = {"believe", "relief", "receipt", "field"};
            return words.Any(w => w.Contains("ei"));
        }

        public IEnumerable<CategoryProducts> Simple69()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Where(x => x.Any(p => p.UnitStock == 0))
                .Select(x => new CategoryProducts {Category = x.Key, Products = x});
        }

        public bool Simple70()
        {
            int[] numbers = {1, 11, 3, 19, 41, 65, 19};
            return numbers.All(x => x % 2 == 1);
        }

        public IEnumerable<CategoryProducts> Simple72()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Where(x => x.All(p => p.UnitStock > 0)).Select(
                x => new CategoryProducts
                {
                    Category = x.Key,
                    Products = x
                });
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nQuantifier Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple67\n2. Simple69\n3. Simple70\n4. Simple72");
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunQuantifiersOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nThere is a word that contains in the list that contains 'ei':");
                        Console.WriteLine(Simple67());
                        break;
                    case "2":
                        Console.WriteLine("\nOne for each category product out of stock:");
                        Display.Display.DisplayCategoryProducts(Simple69(),-1);
                        break;
                    case "3":
                        Console.WriteLine("\nThe list contains only odd numbers:");
                        Console.WriteLine(Simple70());
                        break;
                    case "4":
                        Console.WriteLine("\nAll for each category product in stock:");
                        Display.Display.DisplayCategoryProducts(Simple72(),-1);
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
