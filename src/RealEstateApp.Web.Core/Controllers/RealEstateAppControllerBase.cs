using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Controllers
{
    public abstract class RealEstateAppControllerBase: AbpController
    {
        protected RealEstateAppControllerBase()
        {
            LocalizationSourceName = RealEstateAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
