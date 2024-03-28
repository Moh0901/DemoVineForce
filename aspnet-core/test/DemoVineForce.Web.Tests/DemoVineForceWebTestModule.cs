using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoVineForce.EntityFrameworkCore;
using DemoVineForce.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DemoVineForce.Web.Tests
{
    [DependsOn(
        typeof(DemoVineForceWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DemoVineForceWebTestModule : AbpModule
    {
        public DemoVineForceWebTestModule(DemoVineForceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoVineForceWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DemoVineForceWebMvcModule).Assembly);
        }
    }
}