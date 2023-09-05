using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IOrderItemRepository
    {
        public Task<List<OrderItem>> GetOrderItemsByOrder(int orderId);
    }
}
