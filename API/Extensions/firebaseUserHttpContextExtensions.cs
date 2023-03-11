using System.Security.Claims;
using Domain;

namespace API.Extensions;

public class irebaseUserHttpContextExtensions
{
    public static class GetFirebaseUserHttpContextExtensions
    {
        public static AppUser GetFirebaseUser(HttpContext httpContext)
        {
            var claimsPrincipal = httpContext.User;

            var id = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.ID);
            var email = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.EMAIL);
            var username = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.USERNAME);
            bool.TryParse(claimsPrincipal.FindFirstValue(FirebaseUserClaimType.EMAIL_VERIFIED), out var emailVerified);

            return new AppUser
            {
                Id = id,
                Email = email,
                Username = username,
                EmailVerified = emailVerified
            };
        }
    }
}