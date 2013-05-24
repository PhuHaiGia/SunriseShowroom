using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Showroom.Models.DataAccess;
using Frontend.Models;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        ShowroomRepository rep = new ShowroomRepository();

        public ActionResult Index()
        {
            ViewBag.Message = "Home Showroom car";
            var list = rep.GetProductCatalogueList();
            ViewBag.CatalogueList = (from p in list
                                     select new SelectListItem
                                     {
                                         Value=p.Id.ToString(),
                                         Text=p.Name,
                                     }).ToList();
            //model.listCatalogue = rep
            ViewBag.ProductList = rep.GetProductsList();
            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}

        //public ActionResult List()
        //{
        //    var list = rep.GetProductCatelogueList();
        //    return View(list);
        //}
    }
}
