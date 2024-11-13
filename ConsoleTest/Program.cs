using Common.Config;
using Config.One.Extensions;
using Config.Two.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Read.Config.Extensions;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddReadConfigConfiguration();
        services.AddConfigTwoConfiguration();
        services.AddConfigOneConfiguration();
    })
    .Build();

await host.StartAsync();

var sharedConfig = host.Services.GetRequiredService<SharedConfig>();
Console.WriteLine("Printando no console a partir da aplicação.");
foreach (var kvp in sharedConfig.Configuration)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
