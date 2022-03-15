using ByBlazorApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ByBlazorApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ByBlazorAppEntityFrameworkCoreModule),
    typeof(ByBlazorAppApplicationContractsModule)
    )]
public class ByBlazorAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
