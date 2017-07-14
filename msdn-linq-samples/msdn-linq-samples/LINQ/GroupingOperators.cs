using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class GroupingOperators
    {
        #region Simples



        #endregion

        #region Displays

        public IEnumerable<RemainderNumbers> Simple40()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.GroupBy(x => x % 5).Select(x => new RemainderNumbers {Remainder = x.Key, Numbers = x});
        }

        public IEnumerable<FirstLetterWords> Simple41()
        {
            string[] words = {"blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese"};
            return words.GroupBy(x => x[0]).Select(x => new FirstLetterWords{ FirstLetter = x.Key, Words = x});
        }

        public IEnumerable<CategoryProducts> Simple42()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts {Category = x.Key, Products = x});
        }

        public IEnumerable<> Simple43()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.Select(x => new CompanyNameYearsGroup { CompanyName = x.CompanyName,
                YearsGroup = x.Orders.GroupBy(o => o.Date).Select(yg => new
                    {
                        Year = yg.Key,
                        MonthsGroups = yg.GroupBy(o => o.Date.Month).Select(mg => new {Month = mg.Key, Orders = mg})
                    })
            });
        }

        public IEnumerable<> Simple44()
        {
            
        }

        #endregion
    }
}
