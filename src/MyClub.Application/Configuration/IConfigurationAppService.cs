using System.Threading.Tasks;
using MyClub.Configuration.Dto;

namespace MyClub.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
