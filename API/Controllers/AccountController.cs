using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController
    {
        private readonly IConfiguration _config;
        public AccountController(IConfiguration config)
        {
            _config = config;
        }
    }

    public AccountController(UserManager<AppUser> userManager)
    {

    }

    // static FirebaseAuthConfig 

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        var user = await _userManager.FindByEmailAsync(loginDto.Email);
        // if (user == null) return Unauthorized(new ApiResponse(401));

        // var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
        // if (!result.Succeeded) return Unauthorized(new ApiResponse(401));

        // return new UserDto
        // {
        //     Email = user.Email,
        //     Token = _tokenService.CreateToken(user),
        //     DisplayName = user.DisplayName
        // };
    }
    // [HttpPost("register")]
}