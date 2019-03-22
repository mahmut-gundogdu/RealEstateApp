using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using RealEstateApp.Controllers;

namespace RealEstateApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : RealEstateAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
