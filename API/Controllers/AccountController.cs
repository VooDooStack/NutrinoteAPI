using API.DTOs;
using Application.Account;
using Domain;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[AllowAnonymous]
public class AccountController : BaseApiController
{
    private readonly IConfiguration _config;
    private readonly FirebaseAuthClient _firebaseAuthClient;
    private readonly FirebaseAuthConfig _firebaseAuthConfig;

    public AccountController(IConfiguration config)

    {
        _config = config;

        _firebaseAuthConfig = new FirebaseAuthConfig
        {
            ApiKey = _config["FirebaseApiKey"],
            AuthDomain = _config["FirebaseAuthDomain"],
            Providers = new[]
            {
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
                // ...
            }
        };

        _firebaseAuthClient = new FirebaseAuthClient(_firebaseAuthConfig);
    }

    [HttpPost("login")]
    public async Task<ActionResult<AppUser>> Login(LoginDto loginDto)
    {
        try
        {
            var client = await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(loginDto.Email, loginDto.Password);

            var user = client.User.Info;
            if (user == null) return Unauthorized("No user found with that email");

            var firebaseUser = new AppUser
            {
                Id = user.Uid,
                Email = user.Email,
                EmailVerified = user.IsEmailVerified,
                Username = user.DisplayName,
                Token = await client.User.GetIdTokenAsync()
            };

            return firebaseUser;
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }

    [HttpPost("register")]
    public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
    {
        try
        {
            var user = await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(registerDto.Email,
                registerDto.Password);
            if (registerDto.DisplayName != null) await user.User.ChangeDisplayNameAsync(registerDto.DisplayName);

            var appUser = new AppUser
            {
                Id = user.User.Info.Uid,
                Email = user.User.Info.Email,
                EmailVerified = user.User.Info.IsEmailVerified,
                Token = _firebaseAuthClient.User.GetIdTokenAsync().Result,
                Username = user.User.Info.DisplayName
            };

            Mediator.Send(new Create.Command { AppUser = appUser });

            return appUser;
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }

    [HttpPost("authenticate")]
    public async Task<ActionResult<AppUser>> Authenticate()
    {
        try
        {
            var client = _firebaseAuthClient.User.Info;

            return new AppUser
            {
                Id = client.Uid,
                Email = client.Email,
                EmailVerified = client.IsEmailVerified,
                Username = client.DisplayName,
                Token = await _firebaseAuthClient.User.GetIdTokenAsync()
            };
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }
}