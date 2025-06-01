using Abp.Application.Services;
using abpcqrstest.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace abpcqrstest.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
