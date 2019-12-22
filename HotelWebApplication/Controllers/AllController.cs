using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HotelWebApplication.Controllers
{
    public class AllController : Controller
    {
        private WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "All");
        }

        [Authorize()]
        public ActionResult All()
        {
            IEnumerable<Good> goods = db.Goods;
            ViewBag.Goods = goods;

            return View();
        }
    }
}