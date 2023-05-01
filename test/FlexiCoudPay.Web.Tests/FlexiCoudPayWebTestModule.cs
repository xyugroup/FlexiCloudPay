using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCoudPay.EntityFrameworkCore;
using FlexiCoudPay.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FlexiCoudPay.Web.Tests
{
    [DependsOn(
        typeof(FlexiCoudPayWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FlexiCoudPayWebTestModule : AbpModule
    {
        public FlexiCoudPayWebTestModule(FlexiCoudPayEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCoudPayWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FlexiCoudPayWebMvcModule).Assembly);
        }
    }
}