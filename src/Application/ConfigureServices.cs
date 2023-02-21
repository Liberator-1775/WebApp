using System.Reflection;
using Application.Contacts;
using Application.Contacts.Interfaces;
using Application.Interests;
using Application.Interests.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services.AddAutoMapper(Assembly.GetExecutingAssembly())
            .AddTransient<IContactFacade, ContactFacade>()
            .AddTransient<IInterestFacade, InterestFacade>();
    }
}