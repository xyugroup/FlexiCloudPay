using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCoudPay.Authorization;

namespace FlexiCoudPay
{
    [DependsOn(
        typeof(FlexiCoudPayCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FlexiCoudPayApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FlexiCoudPayAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FlexiCoudPayApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
