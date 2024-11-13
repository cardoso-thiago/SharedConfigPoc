using Common.Config;
using Common.Config.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Config.One.Extensions;

public static class ConfigOneExtension
{
    public static IServiceCollection AddConfigOneConfiguration(this IServiceCollection services)
    {
        services.AddSharedConfig();

        services.Configure<SharedConfig>(config =>
        {
            config.Configuration["ConfigOne:Key1"] = "Value1";
            config.Configuration["ConfigOne:Key2"] = "Value2";
            config.Configuration["ConfigOne:Key3"] = "Value3";
        });

        return services;
    }
}