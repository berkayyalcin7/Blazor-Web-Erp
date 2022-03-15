using ByBlazorApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ByBlazorApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ByBlazorAppController : AbpControllerBase
{
    protected ByBlazorAppController()
    {
        LocalizationResource = typeof(ByBlazorAppResource);
    }
}
