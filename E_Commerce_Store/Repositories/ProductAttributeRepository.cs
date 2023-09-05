using AutoMapper;
using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class ProductAttributeRepository : IProductAttributeRepository
    {
        private readonly DataContext _context;

        public ProductAttributeRepository(DataContext context)
        {
            _context = context;
           
        }
        public async Task<List<ProductAttribute>> GetProductAttributes(Guid productId)
        {
           
            return await _context.ProdcutAttributes.Where(pa => pa.ProductId == productId).ToListAsync();
        }
       public async Task<ProductAttribute> GetProductAttributeByProdcutAttribute(Guid productId, int attributeId,string value)
        {
            return await _context.ProdcutAttributes.Where(pa => pa.ProductId == productId && pa.AttributeId == attributeId && pa.Value == value).FirstOrDefaultAsync();
        }

    }
}
