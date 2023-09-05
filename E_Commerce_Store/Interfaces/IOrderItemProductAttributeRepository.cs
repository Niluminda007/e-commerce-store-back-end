using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IOrderItemProductAttributeRepository
    {
        public Task<List<ProductAttributeDTO>> GetOrderedItemProductAttributesByOrderItemId(OrderItem orderItem);

    }
}
