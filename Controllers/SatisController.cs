using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDbStokTakip.Models.Entity;

namespace MvcDbStokTakip.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDBStokEntities db = new MvcDBStokEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATIS p)
        {
            db.TBLSATIS.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}