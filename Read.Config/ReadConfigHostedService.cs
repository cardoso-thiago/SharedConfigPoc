using Common.Config;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Read.Config;

public class ReadConfigHostedService(SharedConfig sharedConfig, ILogger<ReadConfigHostedService> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        foreach (var kvp in sharedConfig.Configuration)
        {
            logger.LogInformation("Key: {Key}, Value: {Value}", kvp.Key, kvp.Value);
        }
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
