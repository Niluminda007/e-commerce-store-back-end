using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Store.Models
{
    public class Image
    {
       
        public int Id { get; set; }
        public string Url { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
