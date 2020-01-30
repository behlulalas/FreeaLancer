using HaliSaha.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaliSaha.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin, Sadmin")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {

            
            return View();
           


        }
        public ActionResult Rezervasyonlar()
        {
            MyEntities halisahadb = new MyEntities();
            

            var model = halisahadb.Rezervasyon.ToList();

            return View(model);
        }
        [Authorize(Roles = "Sadmin")]
        public ActionResult SaatEkle()
        {

            return View();

        }
            [HttpPost]
            public ActionResult SaatEkle(Saatler saatlerim)
            {
                SaatEntities db = new SaatEntities();
                 db.Saatler.Add(saatlerim);
                 db.SaveChanges();
               

                return View();

            }

        



    }
}