using Application.Common.Interfaces;
using Domain.Contacts;
using Domain.Interests;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        return services.AddDbContext<ApplicationDbContext>(builder =>
                builder.UseInMemoryDatabase("WebApplicationDb"))
            .AddScoped<IApplicationDbContext, ApplicationDbContext>()
            .AddTransient<IRepository<Contact>, ContactRepository>()
            .AddTransient<IRepository<Interest>, InterestRepository>();
    }
}