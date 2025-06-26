
using AdoLite.Abstractions;
using AdoLite.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace AdoLite.Extensions;

public static class DBContextServiceCollectionExtensions
{
    public static IServiceCollection AddDBContext<TContext>(
        this IServiceCollection services,
        Action<DBContextOptions> configureOptions)
        where TContext : class, IDBContext
    {
        services.Configure(configureOptions);

        services.AddScoped<TContext>(provider =>
        {
            var options = provider.GetRequiredService<IOptions<DBContextOptions>>().Value;
            return (TContext)Activator.CreateInstance(typeof(TContext), options)!;
        });

        return services;
    }
}

