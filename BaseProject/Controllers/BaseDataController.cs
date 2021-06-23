using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseProject.Controllers
{
    public class BaseDataController : Controller
    {
        // GET: BaseData
        public ActionResult Index()
        {
            return View();
        }
        // GET: CreateMenu
        public ActionResult CreateMenu()
        {
            return View();
        }
        // GET: Report
        public ActionResult Report()
        {
            return View();
        }
        /// <summary>
        /// 画面：一覧表示
        /// </summary>
        /// <returns></returns>
        public ActionResult ListSansyou()
        {
            return View();
        }
        /// <summary>
        /// 画面：承認一覧表示
        /// </summary>
        /// <returns></returns>
        public ActionResult ListShonin()
        {
            return View();
        }


    }
}