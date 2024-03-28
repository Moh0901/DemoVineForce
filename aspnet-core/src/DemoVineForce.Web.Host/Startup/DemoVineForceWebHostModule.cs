using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoVineForce.Configuration;

namespace DemoVineForce.Web.Host.Startup
{
    [DependsOn(
       typeof(DemoVineForceWebCoreModule))]
    public class DemoVineForceWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoVineForceWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoVineForceWebHostModule).GetAssembly());
        }
    }
}
