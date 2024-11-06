namespace E_Commerce_Store.OrderHeaderModel
{
    public class OrderHeader
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TotalAmount { get; set; }

    }
}
