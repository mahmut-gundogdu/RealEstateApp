using Microsoft.AspNetCore.Antiforgery;
using RealEstateApp.Controllers;

namespace RealEstateApp.Web.Host.Controllers
{
    public class AntiForgeryController : RealEstateAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
