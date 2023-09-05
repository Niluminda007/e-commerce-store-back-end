using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class OrderItemProductAttributeRepository : IOrderItemProductAttributeRepository
    {
        private readonly DataContext _context;
        public OrderItemProductAttributeRepository(DataContext context)
        {
            _context= context;
        }

        public async Task<List<ProductAttributeDTO>> GetOrderedItemProductAttributesByOrderItemId(OrderItem orderItem)
        {
            var orderItemProductItems = await _context.OrderItemProductAttributes
                .Where(oipa => oipa.OrderItemId == orderItem.Id)
                .ToListAsync();

            var productAttributes = new List<ProductAttributeDTO>();

            foreach (var item in orderItemProductItems)
            {
                var productAttribute = await _context.ProdcutAttributes
                    .Where(pa => pa.Id == item.ProductAttributeId)
                    .FirstOrDefaultAsync();

                if (productAttribute != null) 
                {
                    var productAttributeDTO = new ProductAttributeDTO()
                    {
                        Value = productAttribute.Value,
                        AttributeId = productAttribute.AttributeId,
                    };

                    productAttributes.Add(productAttributeDTO); 
                }
            }

            return productAttributes; 
        }

    }
}
