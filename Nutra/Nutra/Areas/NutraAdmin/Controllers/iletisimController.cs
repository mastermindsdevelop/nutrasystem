using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nutra.DAL;
using Nutra.Models;

namespace Nutra.Areas.NutraAdmin.Controllers
{
    public class iletisimController : Controller
    {
        //
        // GET: /NutraAdmin/iletisim/
        nutracon db = new nutracon();
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                ViewBag.ilk = id;
            }
            else
            { 
                ViewBag.ilk = db.iletisim.FirstOrDefault().Id;
            }
            
            return View(db.iletisim.ToList());
        }
        public PartialViewResult detay(int id)
        {
            iletisim ilet = db.iletisim.Find(id);
            ilet.goruldu = 1;
            db.SaveChanges();
            return PartialView(ilet);
        }

    }
}
