using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DemoVineForce.Configuration.Dto;

namespace DemoVineForce.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoVineForceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
