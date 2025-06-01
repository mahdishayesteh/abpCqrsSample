using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpcqrstest.EntityFrameworkCore;
using abpcqrstest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace abpcqrstest.Web.Tests;

[DependsOn(
    typeof(abpcqrstestWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class abpcqrstestWebTestModule : AbpModule
{
    public abpcqrstestWebTestModule(abpcqrstestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(abpcqrstestWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(abpcqrstestWebMvcModule).Assembly);
    }
}