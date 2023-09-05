using AutoMapper;
using Azure;
using BCrypt.Net;
using E_Commerce_Store.Data;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
           
        }

        public async Task<User> CreateUser(UserRegisterModel user)
        {
          
                User newUser = new()
                {
                    UserName = user.UserName,
                    Password = HashPassword(user.Password),
                    FullName = user.UserName,
                    Email = user.Email,
                    Address = user.Address,
                    UserRoleId = 1,
                    PhotoURL = user.PhotoUrl,
                    GoogleUID = user.GoogleUId
                };
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync(); 

               


                return newUser;
      
            
        }

        public async Task<User> AuthenticateUser(LoginRequest model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName);

            if (user == null)
            {
                return null;
            }

            bool isValidPassword = VerifyPassword(user.Password, model.Password);

            if (isValidPassword)
            {
                return user; 
            }

            return null; 
        }
        public async Task<User> GetUserByUserName(string userName)
        {
            return await _context.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
        }

        public string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return "";
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12); 
        }

        public bool VerifyPassword(string hashedPassword, string password)
        {
            
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        public async Task<User> GetUserByGoogleId(string googleId)
        {
      
            return await _context.Users.Where(u => u.GoogleUID == googleId).FirstOrDefaultAsync();
        }
        
    }
}
