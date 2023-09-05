using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IUserRoleRepository
    {
        public Task<UserRole> GetUserRole(int userRoleId);
    }
}
