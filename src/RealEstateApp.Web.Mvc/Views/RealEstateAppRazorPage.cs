using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace RealEstateApp.Web.Views
{
    public abstract class RealEstateAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RealEstateAppRazorPage()
        {
            LocalizationSourceName = RealEstateAppConsts.LocalizationSourceName;
        }
    }
}
