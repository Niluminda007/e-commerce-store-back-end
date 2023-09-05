using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class OrderItemRepository: IOrderItemRepository
    {
        private readonly DataContext _context;
        public OrderItemRepository(DataContext context)
        {
            _context= context;
        }

        public async  Task<List<OrderItem>> GetOrderItemsByOrder(int orderId)
        {
            return await _context.OrderItems.Where(oi => oi.OrderId == orderId).ToListAsync();
        }
    }
}
