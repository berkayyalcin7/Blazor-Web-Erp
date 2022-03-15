using Volo.Abp.Modularity;

namespace ByBlazorApp;

[DependsOn(
    typeof(ByBlazorAppApplicationModule),
    typeof(ByBlazorAppDomainTestModule)
    )]
public class ByBlazorAppApplicationTestModule : AbpModule
{

}
