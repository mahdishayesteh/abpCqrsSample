using Abp.Application.Services;
using abpcqrstest.MultiTenancy.Dto;

namespace abpcqrstest.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

