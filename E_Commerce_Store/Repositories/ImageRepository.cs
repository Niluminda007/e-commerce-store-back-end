using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class ImageRepository:IImageRepository
    {
        private readonly DataContext _context;
        public ImageRepository(DataContext context)
        {
            _context= context;
        }

        public async Task<List<Image>> GetImages(Guid productId)
        {
            return await _context.Images.Where(i=>i.ProductId == productId).ToListAsync();
        }
    }
}
