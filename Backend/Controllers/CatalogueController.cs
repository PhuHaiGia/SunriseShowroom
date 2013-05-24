using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Showroom.Models.DataAccess;
namespace SunriseShowroom.Controllers
{
    public class CatalogueController : Controller
    {
        //
        // GET: /Catalogue/
        private ShowroomRepository rep = new ShowroomRepository();
        public ActionResult Index()
        {
            return View();
        }
        // POST: /Customer/GetList
        [HttpPost]
        [Authorize]
        public ActionResult GetList()
        {
            // Action GetList, dùng cho Grid load danh sách dữ liệu
            var model = rep.GetProductCatalogueList();
            return View(model);
        }
    }
}
