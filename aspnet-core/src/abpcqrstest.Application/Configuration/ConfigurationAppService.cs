using Abp.Authorization;
using Abp.Runtime.Session;
using abpcqrstest.Configuration.Dto;
using System.Threading.Tasks;

namespace abpcqrstest.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : abpcqrstestAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
