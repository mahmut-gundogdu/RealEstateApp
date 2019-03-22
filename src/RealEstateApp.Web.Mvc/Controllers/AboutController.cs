﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using RealEstateApp.Controllers;

namespace RealEstateApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : RealEstateAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
