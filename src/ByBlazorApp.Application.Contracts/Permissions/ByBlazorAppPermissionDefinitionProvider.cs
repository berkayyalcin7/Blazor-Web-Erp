using ByBlazorApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ByBlazorApp.Permissions;

public class ByBlazorAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ByBlazorAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ByBlazorAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ByBlazorAppResource>(name);
    }
}
