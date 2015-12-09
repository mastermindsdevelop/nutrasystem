using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nutra.DAL;
using Nutra.Models;

namespace Nutra.Areas.NutraAdmin.Controllers
{
    
    public class LoginController : Controller
    {
        nutracon db = new nutracon();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(login login)
        {
            if (ModelState.IsValid)
            {
                if (db.login.Where(q => q.username == login.username && q.password == login.password).Count() > 0)
                {
                    Response.Redirect("/NutraAdmin");
                }
                else
                {
                    ViewBag.mesaj = "olmadı";
                }
            }
            return View();
        }

    }
}
