using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security;

public class UserAccessor : IUserAccessor
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetUsername()
    {
        return (_httpContextAccessor.HttpContext.User?.FindFirst(FirebaseUserClaimType.USERNAME)).ToString();
    }

    public string getUserId()
    {
        return (_httpContextAccessor.HttpContext.User?.FindFirst(FirebaseUserClaimType.ID)).ToString();
    }

    public string getEmail()
    {
        return (_httpContextAccessor.HttpContext.User?.FindFirst(FirebaseUserClaimType.EMAIL)).ToString();
    }
}