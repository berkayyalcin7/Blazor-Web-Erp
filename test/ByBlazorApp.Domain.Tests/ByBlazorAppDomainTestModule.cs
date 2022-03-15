using ByBlazorApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ByBlazorApp;

[DependsOn(
    typeof(ByBlazorAppEntityFrameworkCoreTestModule)
    )]
public class ByBlazorAppDomainTestModule : AbpModule
{

}
