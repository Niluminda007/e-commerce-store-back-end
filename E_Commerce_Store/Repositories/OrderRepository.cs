using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public async  Task<List<Order>> GetCustomerOrders(int userId)
        {
            return await _context.Orders.Where(o => o.UserId == userId).ToListAsync();
        }

        public async Task<bool> PlaceOrder(Order order)
        {
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error placing order: {ex.Message}");
                return false;
            }
        }
       
    }
}
