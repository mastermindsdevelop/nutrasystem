using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutra.Areas.NutraAdmin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /NutraAdmin/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
