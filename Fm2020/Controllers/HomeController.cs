using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fm2020.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
