using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Services.OrderService
{
    public interface IOrderService
    {
        public Task<bool> PlaceOrder(OrdersDTO order);
        public Task<List<OrdersDTO>> GetCustomerOrders(int customerId);
    }
}
