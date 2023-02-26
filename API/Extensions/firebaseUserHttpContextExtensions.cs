using System.Security.Claims;
using Domain;

namespace API.Extensions;

public class irebaseUserHttpContextExtensions
{
    public static class GetFirebaseUserHttpContextExtensions
    {
        public static FirebaseUser GetFirebaseUser(HttpContext httpContext)
        {
            var claimsPrincipal = httpContext.User;

            var id = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.ID);
            var email = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.EMAIL);
            var username = claimsPrincipal.FindFirstValue(FirebaseUserClaimType.USERNAME);
            bool.TryParse(claimsPrincipal.FindFirstValue(FirebaseUserClaimType.EMAIL_VERIFIED), out bool emailVerified);

            return new FirebaseUser
            {
                Id = id,
                Email = email,
                Username = username,
                EmailVerified = emailVerified
            };
        }
    } 
}