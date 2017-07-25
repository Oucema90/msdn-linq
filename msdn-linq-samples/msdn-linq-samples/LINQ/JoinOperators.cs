using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class JoinOperators
    {
        #region Simples

        public IEnumerable<CategoryProduct> Simple102()
        {
            var categories = new[] { "Food", "Perfum", "Electronıc", "Medecine", "Movie" };
            var products = DataProvider.GetProductList();
            return categories.Join(products, x => x, y => y.Category,
                (x, y) => new CategoryProduct {Category = x, ProductName = y.ProductName});
        }

        public IEnumerable<CategoryProductGroup> Simple103()
        {
            var categories = new[] { "Food", "Perfum", "Electronıc", "Medecine", "Movie" };
            var products = DataProvider.GetProductList();
            return categories.GroupJoin(products, x => x, y => y.Category,
                (x, y) => new CategoryProductGroup { Category = x, Products = y });
        }

        public IEnumerable<CategoryProduct> Simple104()
        {
            var categories = new[] { "Food", "Perfum", "Electronıc", "Medecine", "Movie" };
            var products = DataProvider.GetProductList();
            return from c in categories
                join p in products on c equals p.Category into ps
                from p in ps
                select new CategoryProduct{ Category = c, ProductName = p.ProductName };
        }

        public IEnumerable<CategoryProduct> Simple105()
        {
            var categories = new[] { "Food", "Perfum", "Electronıc", "Medecine", "Movie" };
            var products = DataProvider.GetProductList();
            return from c in categories
                join p in products on c equals p.Category into ps
                from p in ps.DefaultIfEmpty()
                select new CategoryProduct { Category = c, ProductName = p == null ? "(No products)" : p.ProductName };
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nJoins Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple102\n2. Simple103\n3. Simple104\n4. Simple105");
            Console.WriteLine("\nEsc. Exit");
        }
        #endregion

        public void RunJoinsOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nInner Join:");
                        Display.Display.DisplayCategoryProduct(Simple102());
                        break;
                    case "2":
                        Console.WriteLine("\nCross Join:");
                        Display.Display.DisplayCategoryProductGroup(Simple103());
                        break;
                    case "3":
                        Console.WriteLine("\nGroup Join:");
                        Display.Display.DisplayCategoryProduct(Simple104());
                        break;
                    case "4":
                        Console.WriteLine("\nOuter Join:");
                        Display.Display.DisplayCategoryProduct(Simple105());
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
