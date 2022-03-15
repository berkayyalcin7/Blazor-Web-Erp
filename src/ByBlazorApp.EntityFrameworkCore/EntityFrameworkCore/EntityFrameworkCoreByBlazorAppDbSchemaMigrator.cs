using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ByBlazorApp.Data;
using Volo.Abp.DependencyInjection;

namespace ByBlazorApp.EntityFrameworkCore;

public class EntityFrameworkCoreByBlazorAppDbSchemaMigrator
    : IByBlazorAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreByBlazorAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ByBlazorAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ByBlazorAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
