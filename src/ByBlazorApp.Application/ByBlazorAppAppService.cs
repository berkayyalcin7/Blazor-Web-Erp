using System;
using System.Collections.Generic;
using System.Text;
using ByBlazorApp.Localization;
using Volo.Abp.Application.Services;

namespace ByBlazorApp;

/* Inherit your application services from this class.
 */
public abstract class ByBlazorAppAppService : ApplicationService
{
    protected ByBlazorAppAppService()
    {
        LocalizationResource = typeof(ByBlazorAppResource);
    }
}
