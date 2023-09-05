using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Store.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
