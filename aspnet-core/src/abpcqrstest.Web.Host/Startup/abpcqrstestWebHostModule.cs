using Abp.Modules;
using Abp.Reflection.Extensions;
using abpcqrstest.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace abpcqrstest.Web.Host.Startup
{
    [DependsOn(
       typeof(abpcqrstestWebCoreModule))]
    public class abpcqrstestWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abpcqrstestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abpcqrstestWebHostModule).GetAssembly());
        }
    }
}
