using Abp.Authorization;
using abpcqrstest.Authorization.Roles;
using abpcqrstest.Authorization.Users;

namespace abpcqrstest.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
