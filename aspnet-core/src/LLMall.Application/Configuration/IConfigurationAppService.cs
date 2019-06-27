using System.Threading.Tasks;
using LLMall.Configuration.Dto;

namespace LLMall.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
