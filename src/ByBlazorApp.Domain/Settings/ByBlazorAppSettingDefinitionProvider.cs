using Volo.Abp.Settings;

namespace ByBlazorApp.Settings;

public class ByBlazorAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ByBlazorAppSettings.MySetting1));
    }
}
