using System.Threading.Tasks;
using FlexiCoudPay.Configuration.Dto;

namespace FlexiCoudPay.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
