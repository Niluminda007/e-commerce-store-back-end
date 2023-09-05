namespace E_Commerce_Store.Models
{
    public class Review
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
