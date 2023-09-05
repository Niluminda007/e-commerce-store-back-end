using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IOrderRepository
    {
        public  Task<List<Order>> GetCustomerOrders(int userId);
        public Task<bool> PlaceOrder(Order order);
    }
}
