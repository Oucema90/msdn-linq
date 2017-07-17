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
                YearGrouping = c.Orders.GroupBy(o => o.Date.Year).Select(yg => new YearGroups
                {
                    Year = yg.Key,
                    MonthGrouping = yg.GroupBy(o => o.Date.Month).Select(mg => new MonthGroups
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


        #endregion
    }
}
