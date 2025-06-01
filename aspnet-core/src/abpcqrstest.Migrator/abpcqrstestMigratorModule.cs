using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpcqrstest.Configuration;
using abpcqrstest.EntityFrameworkCore;
using abpcqrstest.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace abpcqrstest.Migrator;

[DependsOn(typeof(abpcqrstestEntityFrameworkModule))]
public class abpcqrstestMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public abpcqrstestMigratorModule(abpcqrstestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(abpcqrstestMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            abpcqrstestConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(abpcqrstestMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
