using E_Commerce_Store.Data;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;


namespace E_Commerce_Store.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly DataContext _context;

        public RefreshTokenRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<RefreshToken> GenerateRefreshToken(User user)
        {
            var refreshToken = new RefreshToken
            {
                UserId = user.Id,
                Token = GenerateRandomToken(),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow
            };

            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return refreshToken;
        }

        public async Task<bool> RefreshTokenExists(string refreshToken)
        {
            var currentToken = await _context.RefreshTokens
                .FirstOrDefaultAsync(rf => rf.Token == refreshToken);

            return currentToken != null;
        }

        public async Task<bool> RefreshTokenExpired(int userId, string refreshToken)
        {
            var token = await _context.RefreshTokens
                .FirstOrDefaultAsync(rf => rf.Token == refreshToken && rf.UserId == userId);

            return token == null || token.Expires <= DateTime.UtcNow;
        }

        private static string GenerateRandomToken()
        {
            var rng = new RNGCryptoServiceProvider();
            var tokenBytes = new byte[64];
            rng.GetBytes(tokenBytes);
            return Convert.ToBase64String(tokenBytes);
        }
    }
}
