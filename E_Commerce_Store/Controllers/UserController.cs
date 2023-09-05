using AutoMapper;
using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using E_Commerce_Store.Services;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace E_Commerce_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly JWTService _jwtService;
        private readonly ILogger<UsersController> _logger;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IUserRoleRepository userRoleRepository,IRefreshTokenRepository refreshTokenRepository, JWTService jwtService, ILogger<UsersController> logger, IMapper mapper)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _jwtService = jwtService;
            _logger = logger;
            _refreshTokenRepository = refreshTokenRepository;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        [ProducesResponseType(200, Type = typeof(UserReponseDTO))]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = await _userRepository.AuthenticateUser(model);
                if (user == null)
                {
                    return NotFound("User not found");
                }

                var token = await GenerateUserToken(user);
                var refreshToken = await GenerateRefreshToken(user);
                SetRefreshToken(refreshToken);

                Response.Headers.Add("Authorization", $"Bearer {token}");
                return Ok(ConvertUserToUserResponseDTO(user));

                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during user authentication.");
                return StatusCode(500, "An error occurred during user authentication.");
            }
        }


        [HttpPost("SignUp/Google")]
        [ProducesResponseType(200, Type = typeof(string))]
        public async Task<IActionResult> SignInWithGoogle([FromBody] UserSignInGoogleModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var uId = await VerifyGoogleTokenAndGetId(model.Token);
                var user = await GetUserOrCreateIfNotExists(model, uId);
                var authToken = await GenerateUserToken(user);
                var refreshToken = await GenerateRefreshToken(user);
                SetRefreshToken(refreshToken);
                Response.Headers.Add("Authorization", $"Bearer {authToken}");

                return Ok(ConvertUserToUserResponseDTO(user));


            }
            catch (FirebaseAuthException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPost("Register")]
        [ProducesResponseType(200, Type = typeof(bool))]
        public async Task<IActionResult> Register([FromBody] UserRegisterModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userRepository.CreateUser(request);
                return Ok("User Registered Successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during user registration.");
                return StatusCode(500, "An error occurred during user registration.");
            }
        }

        private void SetRefreshToken(RefreshToken newRefreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires,
                Path = "/",
                SameSite = SameSiteMode.None, 
                Secure = true 
            };

            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);
        }

        private static async Task<string>  VerifyGoogleTokenAndGetId(string token)
        {

            FirebaseToken decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
            return decodedToken.Uid;
        }
        private async Task<User> GetUserOrCreateIfNotExists(UserSignInGoogleModel userModel,string uId)
        {

            User user = await _userRepository.GetUserByGoogleId(uId);
            if (user == null)
            {
                UserRegisterModel newUserRegisterModel = new()
                {
                    UserName = userModel.UserName,
                    Name = userModel.FullName,
                    Email = userModel.Email,
                    PhotoUrl = userModel.PhotoURL,
                    GoogleUId = uId,
                    
                };

                return await _userRepository.CreateUser(newUserRegisterModel);
            }

            return user;
        }
        private async  Task<string>  GenerateUserToken(User user)
        {
            var userRole = await _userRoleRepository.GetUserRole(user.UserRoleId);
       
            return _jwtService.CreateToken(user, userRole);
        }

        private async Task<RefreshToken> GenerateRefreshToken(User user)
        {
            return await _refreshTokenRepository.GenerateRefreshToken(user);
        }
        private UserReponseDTO ConvertUserToUserResponseDTO(User user)
        {
            var userResponseDTO = _mapper.Map<UserReponseDTO>(user);
            return userResponseDTO;
        }
    }
}
