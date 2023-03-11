using Application.Core;
using Application.Interfaces;
using Application.Products;
using FirebaseAdmin;
using FirebaseAdminAuthentication.DependencyInjection.Extensions;
using Google.Apis.Auth.OAuth2;
using Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers(options =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });

        services.AddSingleton(FirebaseApp.Create(new AppOptions
            {
                ProjectId = "nutrinote-375816",
                Credential = GoogleCredential.FromFile("firebase_admin.json")
            }
        ));
        services.AddFirebaseAuthentication();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseNpgsql(config.GetConnectionString("DefaultConnectionString") ??
                          Environment.GetEnvironmentVariable("DefaultConnectionString"));
        });
        services.AddMediatR(typeof(List.Handler));
        services.AddAutoMapper(typeof(MappingProfiles).Assembly);
        services.AddHttpContextAccessor();
        services.AddScoped<IUserAccessor, UserAccessor>();
        return services;
    }
}