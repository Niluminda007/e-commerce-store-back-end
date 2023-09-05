using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using Microsoft.EntityFrameworkCore;
using Attribute = E_Commerce_Store.Models.Attribute;
namespace E_Commerce_Store.Repositories
{
    public class AttributeRepository:IAttributeRepository
    {
        private readonly DataContext _context;
        public AttributeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Attribute>> GetAttributes()
        {
            return await _context.Attributes.OrderBy(a => a.Name).ToListAsync();
        }

       
    }
}
