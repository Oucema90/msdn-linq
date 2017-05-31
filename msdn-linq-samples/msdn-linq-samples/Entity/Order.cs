using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdn_linq_samples.Entity
{
    public class Order
    {
        public long Id;

        public DateTime Date;

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
    }
}
