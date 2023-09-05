using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class ProductRepository :IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProduct(Guid productId)
        {
            return await _context.Products.Where(p => p.Id == productId).FirstOrDefaultAsync();

        }

        public async Task<ICollection<Product>> GetProducts()
        {
           return await _context.Products.OrderBy(p => p.Name).ToListAsync();
           
        }

        public async Task<bool> ProductExits(Guid productId)
        {
            return await _context.Products.AnyAsync(p=>p.Id== productId);
        }

        public async Task<ICollection<Product>> SearchProducts(string keyword)
        {

            var lowerKeyword = keyword.ToLower();
            return await _context.Products.Where(p => p.Name.ToLower().Contains(keyword)).ToListAsync();
        }
    }
}
