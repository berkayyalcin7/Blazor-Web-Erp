using ByBlazorApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ByBlazorApp.Blazor;

public abstract class ByBlazorAppComponentBase : AbpComponentBase
{
    protected ByBlazorAppComponentBase()
    {
        LocalizationResource = typeof(ByBlazorAppResource);
    }
}
