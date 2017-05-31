using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.LINQ
{
    public class RestrictionOperators
    {
        public static IEnumerable<int> Simple1()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            return numbers.Select(x => x).Where(x => x < 5);

        }

        public static IEnumerable<Product> Simple2()
        {
            var products = Class1.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock == 0);
        }

        public static IEnumerable<Product> Simple3()
        {
            var products = Class1.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock > 0 && x.UnitPrice > 3.00M);
        }
    }
}