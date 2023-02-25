using Application.Core;
using Application.Products;
using FirebaseAdmin;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        // var connectionString = $"database={Environment.GetEnvironmentVariable("database")};server={Environment.GetEnvironmentVariable("server")};port=5432;uid={Environment.GetEnvironmentVariable("user")};pwd={Environment.GetEnvironmentVariable("user_pass")};MinPoolSize=0;MaxPoolSize=100;";
        services.AddSingleton<FirebaseApp>(FirebaseApp.Create());
        services.AddControllers((options) =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });
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