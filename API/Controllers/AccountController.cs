using API.DTOs;
using API.Services;
using Domain;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [AllowAnonymous]
    public class AccountController : BaseApiController
    {
        private readonly IConfiguration _config;
        private readonly FirebaseAuthConfig _firebaseAuthConfig;
        private readonly FirebaseAuthClient _firebaseAuthClient;       
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public SignInManager<AppUser> SignInManager { get; }
        private readonly TokenService _tokenService;

        public AccountController(IConfiguration config, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, TokenService tokenService)

        {
            _tokenService = tokenService;
            SignInManager = signInManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;

            _firebaseAuthConfig = new FirebaseAuthConfig {
            ApiKey = _config["FirebaseApiKey"],
            AuthDomain = _config["FirebaseAuthDomain"],
            Providers = new FirebaseAuthProvider[]
            {
                // Add and configure individual providers
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
                // ...
            }
            };

            _firebaseAuthClient = new FirebaseAuthClient(_firebaseAuthConfig);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return Unauthorized("No user found with that email");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded) return Unauthorized("Incorrect email or password");

            return new UserDto
            {
                Email = user.Email,
                Token = _tokenService.GenerateToken(user),
                DisplayName = user.DisplayName
            };
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {

            var user =  await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(registerDto.Email, registerDto.Password);
            if (registerDto.DisplayName != null)
            {
            await  user.User.ChangeDisplayNameAsync(displayName: registerDto.DisplayName);
            }




            var AppUser = new AppUser
            {
                DisplayName = registerDto.DisplayName,
                Email = registerDto.Email,
                UserName = registerDto.DisplayName,
            };

            var result = await _userManager.CreateAsync(AppUser, registerDto.Password);

            if (result.Succeeded)
            {
                return new UserDto
                {
                    DisplayName = user.User.Info.DisplayName,
                    ImageUrl = user.User.Info.PhotoUrl,
                    Token = await user.User.GetIdTokenAsync(),
                };
            }

            return BadRequest(result.Errors);
        }
    }
}