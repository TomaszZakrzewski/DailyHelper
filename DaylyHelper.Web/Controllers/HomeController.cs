using DaylyHelper.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaylyHelper.Web.Controllers
{
    public class HomeController : Controller
    {
        IDayHelperData db;

        public HomeController(IDayHelperData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}