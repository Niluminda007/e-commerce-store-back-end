namespace E_Commerce_Store.Models
{
    public class Order
    {

        public int Id { get; set; }
        public DateTime  OrderDate { get; set; }
        public double Total { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
