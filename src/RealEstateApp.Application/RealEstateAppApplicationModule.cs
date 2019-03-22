using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateApp.Authorization;

namespace RealEstateApp
{
    [DependsOn(
        typeof(RealEstateAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RealEstateAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RealEstateAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RealEstateAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
