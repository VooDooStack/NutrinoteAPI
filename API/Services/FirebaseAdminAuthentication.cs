using System.Security.Claims;
using Domain;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace API.Services;

public abstract class FirebaseAdminAuthentication
{
    public class FirebaseAuthenticationFunctionHandler
    {
        private const string BEARER_PREFIX = "Bearer ";

        private readonly FirebaseApp _firebaseApp;

        public FirebaseAuthenticationFunctionHandler(FirebaseApp firebaseApp)
        {
            _firebaseApp = firebaseApp;
        }

        public Task<AuthenticateResult> HandleAuthenticateAsync(HttpRequest request)
        {
            return HandleAuthenticateAsync(request.HttpContext);
        }

        public async Task<AuthenticateResult> HandleAuthenticateAsync(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey("Authorization")) return AuthenticateResult.NoResult();

            string bearerToken = context.Request.Headers["Authorization"];

            if (bearerToken == null || !bearerToken.StartsWith(BEARER_PREFIX))
                return AuthenticateResult.Fail("Invalid scheme.");

            var token = bearerToken[BEARER_PREFIX.Length..];

            try
            {
                var firebaseToken = await FirebaseAuth.GetAuth(_firebaseApp).VerifyIdTokenAsync(token);

                return AuthenticateResult.Success(CreateAuthenticationTicket(firebaseToken));
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail(ex);
            }
        }

        private AuthenticationTicket CreateAuthenticationTicket(FirebaseToken firebaseToken)
        {
            var claimsPrincipal = new ClaimsPrincipal(new List<ClaimsIdentity>
            {
                new(ToClaims(firebaseToken.Claims), nameof(ClaimsIdentity))
            });

            return new AuthenticationTicket(claimsPrincipal, JwtBearerDefaults.AuthenticationScheme);
        }

        private IEnumerable<Claim> ToClaims(IReadOnlyDictionary<string, object> claims)
        {
            return new List<Claim>
            {
                new(FirebaseUserClaimType.ID, claims.GetValueOrDefault("user_id", "").ToString()),
                new(FirebaseUserClaimType.EMAIL, claims.GetValueOrDefault("email", "").ToString()),
                new(FirebaseUserClaimType.EMAIL_VERIFIED, claims.GetValueOrDefault("email_verified", "").ToString()),
                new(FirebaseUserClaimType.USERNAME, claims.GetValueOrDefault("name", "").ToString())
            };
        }
    }
}