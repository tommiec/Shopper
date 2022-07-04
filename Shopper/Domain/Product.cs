using System.ComponentModel.DataAnnotations;

namespace Shopper.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Unit { get; set; }
        public double Price { get; set; }
    }
}
