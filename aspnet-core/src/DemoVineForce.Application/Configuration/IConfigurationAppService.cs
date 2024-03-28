using System.Threading.Tasks;
using DemoVineForce.Configuration.Dto;

namespace DemoVineForce.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
