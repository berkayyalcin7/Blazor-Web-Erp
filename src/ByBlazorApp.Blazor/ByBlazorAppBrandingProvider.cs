using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ByBlazorApp.Blazor;

[Dependency(ReplaceServices = true)]
public class ByBlazorAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ByBlazorApp";
}
