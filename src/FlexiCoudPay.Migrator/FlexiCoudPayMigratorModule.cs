using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCoudPay.Configuration;
using FlexiCoudPay.EntityFrameworkCore;
using FlexiCoudPay.Migrator.DependencyInjection;

namespace FlexiCoudPay.Migrator
{
    [DependsOn(typeof(FlexiCoudPayEntityFrameworkModule))]
    public class FlexiCoudPayMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FlexiCoudPayMigratorModule(FlexiCoudPayEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FlexiCoudPayMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FlexiCoudPayConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCoudPayMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
