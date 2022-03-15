using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ByBlazorApp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ByBlazorAppDbContextFactory : IDesignTimeDbContextFactory<ByBlazorAppDbContext>
{
    public ByBlazorAppDbContext CreateDbContext(string[] args)
    {
        ByBlazorAppEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ByBlazorAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ByBlazorAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ByBlazorApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
