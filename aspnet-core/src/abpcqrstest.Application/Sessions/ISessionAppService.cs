using Abp.Application.Services;
using abpcqrstest.Sessions.Dto;
using System.Threading.Tasks;

namespace abpcqrstest.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
