using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;
using msdn_linq_samples.Utils;

namespace msdn_linq_samples.LINQ
{
    public class OrderingOperators
    {
        #region Simples

        public IEnumerable<string> Simple28()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.OrderBy(x => x);
        }

        public IEnumerable<string> Simple29()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.OrderBy(x => x.Length);
        }

        public IEnumerable<Product> Simple30()
        {
            var products = DataProvider.GetProductList();
            return products.OrderBy(x => x.Name);
        }

        public IEnumerable<string> Simple31()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(x => x, new CaseInsensitiveComparer());
        }

        public IEnumerable<double> Simple32()
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};
            return doubles.OrderByDescending(x => x);
        }

        public IEnumerable<Product> Simple33()
        {
            var products = DataProvider.GetProductList();
            return products.OrderByDescending(x => x.UnitStock);
        }

        public IEnumerable<string> Simple34()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderByDescending(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<string> Simple35()
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return digits.OrderBy(x => x.Length).ThenBy(x => x);
        }

        public IEnumerable<string> Simple36()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<Product> Simple37()
        {
            var products = DataProvider.GetProductList();
            return products.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
        }

        public IEnumerable<string> Simple38()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<string> Simple39()
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return digits.Where(x => x[1] == 'i').Reverse();
        }

        #endregion

        #region Displays

        #endregion
    }
}
