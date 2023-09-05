using E_Commerce_Store.Models;

namespace E_Commerce_Store.DTO
{
    public class OrdersDTO
    {
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }

    }
}
