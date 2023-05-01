using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCoudPay.Configuration;

namespace FlexiCoudPay.Web.Host.Startup
{
    [DependsOn(
       typeof(FlexiCoudPayWebCoreModule))]
    public class FlexiCoudPayWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FlexiCoudPayWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCoudPayWebHostModule).GetAssembly());
        }
    }
}
