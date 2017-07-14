using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdn_linq_samples.Anonymous_Types
{
    public class RemainderNumbers
    {
        public int Remainder { get; set; }

        public IGrouping<int,int> Numbers { get; set; }
    }
}
