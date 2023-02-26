using API.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace API.Extensions;

public static class AddFirebaseAuthenticationExtensions
{
    public static IServiceCollection AddFirebaseAuthentication(this IServiceCollection services)
    {
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddScheme<AuthenticationSchemeOptions, FirebaseAuthenticationHandler>(
                JwtBearerDefaults.AuthenticationScheme, (o) => { });

        services.AddScoped<FirebaseAdminAuthentication.FirebaseAuthenticationFunctionHandler>();

        return services;
    } 
}