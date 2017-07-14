

namespace msdn_linq_samples.Entity
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public int UnitStock { get; set; }

        public decimal UnitPrice { get; set; }

        public string Category { get; set; }

        public string Category { get; set; }

        public Product(string name, int unitStock, decimal unitPrice)
        {
            ProductName = name;
            UnitStock = unitStock;
            UnitPrice = unitPrice;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return $"ProductID={ProductId} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice} UnitsInStock={UnitStock}";
        }
    }
}