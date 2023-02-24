using Application.Core;
using Application.Products;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        //services.AddSingleton<FirebaseApp>(FirebaseApp.Create());
        services.AddControllers((options) =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<Persistence.DataContext>(opt =>
        {
            opt.UseNpgsql(
                $"database={Environment.GetEnvironmentVariable("database")};server={Environment.GetEnvironmentVariable("server")};port=5432;uid={Environment.GetEnvironmentVariable("user")};pwd={Environment.GetEnvironmentVariable("user_pass")};MinPoolSize=0;MaxPoolSize=100;");
        });
        services.AddMediatR(typeof(List.Handler));
        services.AddAutoMapper(typeof(MappingProfiles).Assembly);

        return services;
    }
}