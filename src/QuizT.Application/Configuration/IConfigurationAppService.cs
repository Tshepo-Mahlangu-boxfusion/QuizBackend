using System.Threading.Tasks;
using QuizT.Configuration.Dto;

namespace QuizT.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
