using System.Threading.Tasks;

namespace ByBlazorApp.Data;

public interface IByBlazorAppDbSchemaMigrator
{
    Task MigrateAsync();
}
