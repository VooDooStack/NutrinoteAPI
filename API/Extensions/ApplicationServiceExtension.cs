using Application.Core;
using Application.FoodItems;
using FirebaseAdmin;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers((options) => {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });
        //services.AddSingleton<FirebaseApp>(FirebaseApp.Create());
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<Persistence.DataContext>(opt => {
            opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        });
        services.AddMediatR(typeof(UpdateOrCreate.Handler));
        services.AddAutoMapper(typeof(MappingProfiles).Assembly);

        return services;
    }
}