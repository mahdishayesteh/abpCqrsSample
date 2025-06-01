using Abp.MultiTenancy;
using abpcqrstest.Authorization.Users;

namespace abpcqrstest.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
