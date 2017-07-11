

namespace msdn_linq_samples.Entity
{
    public class Product
    {
        public string Name;

        public int UnitStock;

        public decimal UnitPrice;

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