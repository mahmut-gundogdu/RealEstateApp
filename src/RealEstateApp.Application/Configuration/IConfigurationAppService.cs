using System.Threading.Tasks;
using RealEstateApp.Configuration.Dto;

namespace RealEstateApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
