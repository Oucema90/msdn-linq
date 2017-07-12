

namespace msdn_linq_samples.Entity
{
    public class Product
    {
        public string Name { get; set; }

        public int UnitStock { get; set; }

        public decimal UnitPrice { get; set; }

        public string Category { get; set; }

        public Product(string name, int unitStock, decimal unitPrice)
        {
            Name = name;
            UnitStock = unitStock;
            UnitPrice = unitPrice;
        }

        public Product()
        {
        }
    }
}