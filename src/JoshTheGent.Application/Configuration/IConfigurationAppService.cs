using System.Threading.Tasks;
using JoshTheGent.Configuration.Dto;

namespace JoshTheGent.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
