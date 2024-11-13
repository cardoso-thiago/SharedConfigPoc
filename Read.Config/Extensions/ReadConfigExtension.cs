using Common.Config.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Read.Config.Extensions;

public static class ReadConfigExtension
{
    public static IServiceCollection AddReadConfigConfiguration(this IServiceCollection services)
    {
        services.AddSharedConfig();
        services.AddHostedService<ReadConfigHostedService>();
        return services;
    }
}