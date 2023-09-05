using E_Commerce_Store.Models;

namespace E_Commerce_Store.Interfaces
{
    public interface IRefreshTokenRepository
    {
        public Task<bool> RefreshTokenExists(string refreshToken);
        public Task<bool> RefreshTokenExpired(int userId, string refreshToken);
        public Task<RefreshToken> GenerateRefreshToken(User user);

    }
}
