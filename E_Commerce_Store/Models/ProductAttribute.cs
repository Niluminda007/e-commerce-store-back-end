using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Store.Models
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public string Value { get; set; }
        public Attribute Attribute { get; set; }
        public int AttributeId { get; set; }
        public ICollection<OrderItemProductAttribute>? OrderItemProductAttributes { get; set; }

    }
}
