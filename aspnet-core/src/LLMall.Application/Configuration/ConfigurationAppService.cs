using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LLMall.Configuration.Dto;

namespace LLMall.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LLMallAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
