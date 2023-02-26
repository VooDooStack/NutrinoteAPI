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
        private readonly UserManager<FirebaseUser> _userManager;
        private readonly SignInManager<FirebaseUser> _signInManager;
        public SignInManager<FirebaseUser> SignInManager { get; }
        // private readonly FirebaseAdminAuthentication _tokenService;

        public AccountController(IConfiguration config, UserManager<FirebaseUser> userManager, SignInManager<FirebaseUser> signInManager)

        {
            // _tokenService = tokenService;
            SignInManager = signInManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;

            _firebaseAuthConfig = new FirebaseAuthConfig
            {
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
            UserCredential client = await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(loginDto.Email, loginDto.Password);

            var user = await _userManager.FindByEmailAsync(client.User.Info.Email);
            if (user == null) return Unauthorized("No user found with that email");

            return new UserDto
            {
                Email = user.Email,
                Token = await client.User.GetIdTokenAsync(),
                DisplayName = user.Username
            };
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            var user = await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(registerDto.Email, registerDto.Password);
            if (registerDto.DisplayName != null)
            {
                await user.User.ChangeDisplayNameAsync(displayName: registerDto.DisplayName);
            }

            var AppUser = new FirebaseUser
            {
                Id = user.User.Info.Uid,
                Email = user.User.Info.Email,
                EmailVerified = user.User.Info.IsEmailVerified,
                Username = user.User.Info.DisplayName,
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

            return Unauthorized(result.Errors);
        }
    }
}