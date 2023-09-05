using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IImageRepository
    {
        public Task<List<Image>> GetImages(Guid productId);
    }
}
