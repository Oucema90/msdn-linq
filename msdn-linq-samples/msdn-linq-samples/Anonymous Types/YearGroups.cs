using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdn_linq_samples.Anonymous_Types
{
    public class YearGroups
    {
        public int Year { get; set; }

        public IEnumerable<MonthGroups> MonthGrouping { get; set; }
    }
}
