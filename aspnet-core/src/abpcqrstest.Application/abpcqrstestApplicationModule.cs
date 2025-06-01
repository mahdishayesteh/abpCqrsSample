using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpcqrstest.Authorization;

namespace abpcqrstest;

[DependsOn(
    typeof(abpcqrstestCoreModule),
    typeof(AbpAutoMapperModule))]
public class abpcqrstestApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<abpcqrstestAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(abpcqrstestApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
