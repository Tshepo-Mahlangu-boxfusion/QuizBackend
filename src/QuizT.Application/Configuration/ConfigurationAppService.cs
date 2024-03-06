using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QuizT.Configuration.Dto;

namespace QuizT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QuizTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
