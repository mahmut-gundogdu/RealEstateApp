using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateApp.Configuration;

namespace RealEstateApp.Web.Host.Startup
{
    [DependsOn(
       typeof(RealEstateAppWebCoreModule))]
    public class RealEstateAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RealEstateAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RealEstateAppWebHostModule).GetAssembly());
        }
    }
}
