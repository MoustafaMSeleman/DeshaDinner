using DeshaDinner.Application.Common.Interfaces;
using DeshaDinner.Infrastructure.Authentication;
using DeshaDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeshaDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJWTGenerator, JWTGenerator>();   
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
