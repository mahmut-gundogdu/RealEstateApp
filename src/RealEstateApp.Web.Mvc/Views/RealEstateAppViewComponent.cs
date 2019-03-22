using Abp.AspNetCore.Mvc.ViewComponents;

namespace RealEstateApp.Web.Views
{
    public abstract class RealEstateAppViewComponent : AbpViewComponent
    {
        protected RealEstateAppViewComponent()
        {
            LocalizationSourceName = RealEstateAppConsts.LocalizationSourceName;
        }
    }
}
