using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nutra.DAL;
using Nutra.Models;
using System.Data;
using System.Data.Entity;

namespace Nutra.Controllers
{
    public class iletisimController : Controller
    {
        nutracon db = new nutracon();
        public ActionResult Index()
        {
            List<sube> s = db.sube.ToList();
            List<nereden> n = db.nereden.ToList();
            ViewData["subeler"] = s;
            ViewData["nereden"] = n;
            //db.Database.ExecuteSqlCommand("TRUNCATE TABLE iletisims");
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim iletisim)
        {
            ViewData["subeler"] = db.sube.ToList();
            ViewData["nereden"] = db.nereden.ToList();
            if (ModelState.IsValid)
            {
                iletisim.tarih = System.DateTime.Now.ToShortDateString();
                iletisim.sube = db.sube.Find(iletisim.sube.Id);
                iletisim.nereden = db.nereden.Find(iletisim.nereden.Id);
                db.Entry(iletisim).State = EntityState.Added;
                db.SaveChanges();
                ViewBag.mesaj = "Eklendi";
            }
            else
            {
                ViewBag.mesaj = "Hata !";
            }
            return View(iletisim);
        }
    }
}
