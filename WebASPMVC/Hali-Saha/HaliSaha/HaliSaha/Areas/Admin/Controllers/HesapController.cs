using HaliSaha.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaliSaha.Areas.Admin.Controllers
{
    public class HesapController : Controller
    {
        // GET: Admin/Hesap
    
        public ActionResult Login()
        {
            if (Session["kullaniciadi"]!=null)
            {
               return RedirectToAction("Index", "Home", new { username = Session["kullaniciadi"].ToString() });

            }
            else
            {
                return View();
            }
          

        }
        [HttpPost]
        public ActionResult Login(Users users)
        {
            Model1 mdl1 = new Model1();
            var userlogin = mdl1.Users.SingleOrDefault(x => x.UserName == users.UserName && x.UserPassword == users.UserPassword);
            if (userlogin != null)
            {
                ViewBag.message = "loggedin";
                ViewBag.triedOnce = "yes";
                Session["kullaniciadi"] = users.UserName;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.triedOnce = "yes";
                return View();
            }
        }
        public ActionResult Cikis()
        {
           
            Session.Abandon(); // it will clear the session at the end of request
            return View();
        }
    }
}