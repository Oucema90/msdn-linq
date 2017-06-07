using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Utils;

namespace msdn_linq_samples.LINQ
{
    public class RestrictionOperators
    {
        public IEnumerable<int> Simple1()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            return numbers.Select(x => x).Where(x => x < 5);

        }

        public IEnumerable<Product> Simple2()
        {
            var products = RestrictionOperatorsUtils.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock == 0);
        }

        public IEnumerable<Product> Simple3()
        {
            var products = RestrictionOperatorsUtils.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock > 0 && x.UnitPrice > 3.00M);
        }

        public IEnumerable<Customer> Simple4()
        {
            var customers = RestrictionOperatorsUtils.GetCustomersList();
            return customers.Select(c => c).Where(c => c.Region == "WA");
        }

        public IEnumerable<string> Simple5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return digits.Where((digit, index) => digit.Length < index);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Restriction Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple1");
            Console.WriteLine("2. Simple2");
            Console.WriteLine("3. Simple3");
            Console.WriteLine("4. Simple4");
            Console.WriteLine("5. Simple5");
            Console.WriteLine("Esc. Exit");
        }
    }
}