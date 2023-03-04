using API.Services;
using Application.Core;
using Application.Products;
using FirebaseAdmin;
using FirebaseAdminAuthentication.DependencyInjection.Extensions;
using Google.Apis.Auth.OAuth2;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers((options) =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });
        
        services.AddSingleton<FirebaseApp>(FirebaseApp.Create(options: new AppOptions()
            {
                ProjectId = "nutrinote-7daa5",
                Credential = GoogleCredential.FromFile("firebase_admin.json")
            }
        ));
        services.AddFirebaseAuthentication();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<Persistence.DataContext>(opt =>
        {
            opt.UseNpgsql(config.GetConnectionString("DefaultConnectionString") ?? Environment.GetEnvironmentVariable("DefaultConnectionString"));
        });
        services.AddMediatR(typeof(List.Handler));
        services.AddAutoMapper(typeof(MappingProfiles).Assembly);
        return services;
    }
}