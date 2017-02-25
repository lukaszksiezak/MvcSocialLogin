using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialMediaLoginApp.Controllers
{

    public class HomeController : Controller
    {
        [RequireHttps]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}