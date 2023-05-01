using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FlexiCoudPay.Configuration.Dto;

namespace FlexiCoudPay.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FlexiCoudPayAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
