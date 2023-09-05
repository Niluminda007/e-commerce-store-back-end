using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetProducts();
        Task<Product> GetProduct(Guid productId);
        Task<bool> ProductExits(Guid productId);
        Task<ICollection<Product>> SearchProducts(string keyword);

    }
}
