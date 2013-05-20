using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Showroom.Models.DataAccess;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        ShowroomRepository rep = new ShowroomRepository();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult List()
        {
            var list = rep.GetProductCatelogueList();
            return View(list);
        }
    }
}
