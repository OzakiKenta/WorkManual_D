using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BaseProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string login_id, string login_pass)
        {
            login_id = login_id ?? "";
            login_pass = login_pass ?? "";
            if (login_id != "" && login_pass != "")
            {
                FormsAuthentication.SetAuthCookie(login_id, false);
                return RedirectToAction("Index", "MainMenu");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}