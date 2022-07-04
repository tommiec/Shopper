namespace Shopper.Domain
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public Shipper Shipper { get; set; }
    }

    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quatity { get; set; }
    }
}
