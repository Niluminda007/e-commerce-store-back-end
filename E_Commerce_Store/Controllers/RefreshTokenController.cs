using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using E_Commerce_Store.Services;

using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefreshTokenController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly JWTService _jwtService;
        private readonly IUserRoleRepository _userRoleRepository;

        public RefreshTokenController(IUserRepository userRepository, IRefreshTokenRepository refreshTokenRepository, JWTService jwtService, IUserRoleRepository userRoleRepository)
        {
            _refreshTokenRepository = refreshTokenRepository ?? throw new ArgumentNullException(nameof(refreshTokenRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _jwtService = jwtService ?? throw new ArgumentNullException(nameof(jwtService));
            _userRoleRepository = userRoleRepository ?? throw new ArgumentNullException(nameof(userRoleRepository));
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(UserDTO userDTO)
        {
            if (userDTO == null || string.IsNullOrWhiteSpace(userDTO.UserName))
            {
                return BadRequest("Invalid user data.");
            }

            var refreshToken = Request.Cookies["refreshToken"];
            var user = await _userRepository.GetUserByUserName(userDTO.UserName);

            if (!await _refreshTokenRepository.RefreshTokenExists(refreshToken))
            {
                return Unauthorized("Invalid Refresh Token");
            }
            if (await _refreshTokenRepository.RefreshTokenExpired(user.Id, refreshToken))
            {
                return Unauthorized("Token expired");
            }

            var userRole = await _userRoleRepository.GetUserRole(user.UserRoleId);
            if (userRole == null)
            {
                return NotFound("User role not found.");
            }

            string token = _jwtService.CreateToken(user, userRole);
            var newRefreshToken = await _refreshTokenRepository.GenerateRefreshToken(user);
            SetRefreshToken(newRefreshToken);

            return Ok(token);
        }

        private void SetRefreshToken(RefreshToken newRefreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires,
                
            };
            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);
        }
    }
}
