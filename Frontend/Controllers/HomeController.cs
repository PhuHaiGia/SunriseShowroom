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
            ViewBag.Message = "Home Showroom car";
            var list = rep.GetProductCatalogueList();
            ViewBag.CatalogueListDrop = (from p in list
                                     select new SelectListItem
                                     {
                                         Value=p.Id.ToString(),
                                         Text=p.Name,
                                     }).ToList();
            // Danh sách dữ liệu danh mục
            ViewBag.CataloguesList = rep.GetProductCatalogueList();
            // Danh sách dữ liệu sản phẩm
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
