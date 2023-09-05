using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Store.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
