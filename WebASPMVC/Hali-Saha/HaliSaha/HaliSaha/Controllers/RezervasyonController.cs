
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaliSaha.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


namespace HaliSaha.Controllers
{
    [Authorize]
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Rezervasyon()
        {
            
            halisahadb db = new halisahadb();
            DateTime date = DateTime.Now.Date;
            List<Rezervasyon> ListeRez=db.Rezervasyon.Where(c=> c.tarih==date).ToList();
            List<Saatler> ListeSaat= db.Saatler.ToList();
            return View(Tuple.Create(ListeRez,ListeSaat));
        }
        [HttpPost]
        public ActionResult Rezervasyon(FormCollection form)
        {
            halisahadb halisahadb = new halisahadb();
            Rezervasyon model = new Rezervasyon();
            model.userid = User.Identity.GetUserId();
            model.adsoyad = form["ad"].Trim();
            model.telefon= form["telefon"].Trim();
            model.tarih= Convert.ToDateTime(form["tarih"].Trim());
            model.saat = form["saat"].Trim();
            model.Durum = false;
            DateTime data;
            data = Convert.ToDateTime(form["tarih"]);
            data.ToShortDateString();
            string saat = form["saat"];
          var durum=halisahadb.Rezervasyon.Where(c=> c.tarih==data && c.saat==saat).Count();
            if (durum>0)
            {
                ViewBag.Hatamesaj = "Rezervasyon Dolu";
                return RedirectToAction("Rezervasyon", "Rezervasyon");
            }
            else
            {
                halisahadb.Rezervasyon.Add(model);
                halisahadb.SaveChanges();
                return RedirectToAction("Rezervasyon", "Rezervasyon");
            }

            
        }
        public ActionResult Profilim()
        {
                var iduser = User.Identity.GetUserId();
                halisahadb halisahadb = new halisahadb();
                var model = halisahadb.Rezervasyon.Where(c => c.userid == iduser).ToList();
                return View(model);

        }

    }
}