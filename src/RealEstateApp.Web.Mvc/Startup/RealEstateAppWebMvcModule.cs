using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateApp.Configuration;

namespace RealEstateApp.Web.Startup
{
    [DependsOn(typeof(RealEstateAppWebCoreModule))]
    public class RealEstateAppWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RealEstateAppWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<RealEstateAppNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RealEstateAppWebMvcModule).GetAssembly());
        }
    }
}
