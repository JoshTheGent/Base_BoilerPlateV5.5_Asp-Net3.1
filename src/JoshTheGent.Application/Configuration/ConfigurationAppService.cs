using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JoshTheGent.Configuration.Dto;

namespace JoshTheGent.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JoshTheGentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
