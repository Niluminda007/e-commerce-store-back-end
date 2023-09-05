using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategories();
        Task<ICollection<Product>> GetProductsByCategory(int categoryId);
        Task<bool> CategoryExists(int categoryId);
    }
}
