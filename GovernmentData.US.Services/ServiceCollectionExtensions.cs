using GovernmentData.US.Services;
using GovernmentData.US.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAllGovermentServices(this IServiceCollection services)
    {
        services.AddSingleton<IDisasterService, DisasterService>();
        // Add other services here
        return services;
    }
}
