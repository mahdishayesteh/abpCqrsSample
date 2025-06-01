using abpcqrstest.Configuration.Dto;
using System.Threading.Tasks;

namespace abpcqrstest.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
