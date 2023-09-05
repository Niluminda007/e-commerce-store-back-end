using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class UserRoleRepository:IUserRoleRepository
    {
        private readonly DataContext _context;
        public UserRoleRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<UserRole> GetUserRole(int userRoleId)
        {
            return await _context.UserRoles.SingleOrDefaultAsync(u => u.Id == userRoleId);
        }
    }
}
