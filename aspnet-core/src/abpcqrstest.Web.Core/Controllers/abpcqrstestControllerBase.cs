using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abpcqrstest.Controllers
{
    public abstract class abpcqrstestControllerBase : AbpController
    {
        protected abpcqrstestControllerBase()
        {
            LocalizationSourceName = abpcqrstestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
