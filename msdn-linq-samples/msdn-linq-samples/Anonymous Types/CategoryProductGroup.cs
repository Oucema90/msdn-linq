using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Entity;

namespace msdn_linq_samples.Anonymous_Types
{
    public class CategoryProductGroup
    {
        public string Category { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
