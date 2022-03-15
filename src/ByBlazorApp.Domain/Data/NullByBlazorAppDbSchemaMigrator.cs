using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ByBlazorApp.Data;

/* This is used if database provider does't define
 * IByBlazorAppDbSchemaMigrator implementation.
 */
public class NullByBlazorAppDbSchemaMigrator : IByBlazorAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
