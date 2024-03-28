using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoVineForce.Authorization;

namespace DemoVineForce
{
    [DependsOn(
        typeof(DemoVineForceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoVineForceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoVineForceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoVineForceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
