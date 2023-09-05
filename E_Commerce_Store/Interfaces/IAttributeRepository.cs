using E_Commerce_Store.Models;
using Attribute = E_Commerce_Store.Models.Attribute;

namespace E_Commerce_Store.Interfaces
{
    public interface IAttributeRepository
    {
        public Task<List<Attribute>> GetAttributes();
    }
}
