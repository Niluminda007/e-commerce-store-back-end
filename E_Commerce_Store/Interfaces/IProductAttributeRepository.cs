using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IProductAttributeRepository
    {
        public Task<List<ProductAttribute>> GetProductAttributes(Guid productId);
        public Task<ProductAttribute> GetProductAttributeByProdcutAttribute(Guid productId, int attributeId, string value);


    }
}
