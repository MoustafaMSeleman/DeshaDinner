using DeshaDinner.Api.Common.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics.CodeAnalysis;

namespace DeshaDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddSingleton<ProblemDetailsFactory, DeshaDinnerProblemDetailsFactory>();
        return services;
    }
}
