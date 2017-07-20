using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Anonymous_Types
{
    public class MonthGroups
    {
        public int Month { get; set; }

        public IGrouping<int, Order> Orders { get; set; }
    }
}