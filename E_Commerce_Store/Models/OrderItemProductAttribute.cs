namespace E_Commerce_Store.Models
{
    public class OrderItemProductAttribute
    {
        public int Id { get; set; } 
        public int OrderItemId { get; set; }
        public int ProductAttributeId { get; set; }

        public OrderItem OrderItem { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
    }
}
