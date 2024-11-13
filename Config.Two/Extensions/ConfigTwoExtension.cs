using Common.Config;
using Common.Config.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Config.Two.Extensions;

public static class ConfigTwoExtension
{
    public static IServiceCollection AddConfigTwoConfiguration(this IServiceCollection services)
    {
        services.AddSharedConfig();

        services.Configure<SharedConfig>(config =>
        {
            config.Configuration["ConfigTwo:Key4"] = "Value4";
            config.Configuration["ConfigOne:Key5"] = "Value5";
            config.Configuration["ConfigOne:Key6"] = "Value6";
        });

        return services;
    }
}