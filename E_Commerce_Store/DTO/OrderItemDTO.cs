using E_Commerce_Store.Models;

namespace E_Commerce_Store.DTO
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public ProductDTO Product { get; set; }
        public List<ProductAttributeDTO>? Attributes { get; set; }

    }
}
