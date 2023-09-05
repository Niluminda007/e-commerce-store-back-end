namespace E_Commerce_Store.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product{ get; set; }
        public Guid ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public ICollection<OrderItemProductAttribute>? OrderItemProductAttributes { get; set; }

    
      


    }
}
