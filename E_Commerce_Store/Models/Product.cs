using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Store.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        public ICollection<ProductAttribute>? ProductAttributes { get; set; }


    }
}
