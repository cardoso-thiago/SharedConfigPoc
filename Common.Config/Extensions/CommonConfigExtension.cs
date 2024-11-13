using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Common.Config.Extensions;

public static class CommonConfigExtension
{
    public static IServiceCollection AddSharedConfig(this IServiceCollection services)
    {
        services.AddOptions<SharedConfig>().Configure(_ => { });
        services.AddSingleton<SharedConfig>(sp =>
        {
            var options = sp.GetRequiredService<IOptions<SharedConfig>>().Value;
            return options;
        });
        return services;
    }
}