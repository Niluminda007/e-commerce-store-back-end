using E_Commerce_Store.DTO;
using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateUser(UserRegisterModel user);
        public Task<User> AuthenticateUser(LoginRequest model);
        string HashPassword(string password);
        bool VerifyPassword(string hashedPassword, string password);
        public Task<User> GetUserByUserName(string userName);
        public Task<User> GetUserByGoogleId(string googleId);


    }
}
