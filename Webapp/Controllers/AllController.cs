using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Webapp.Dal;
using Webapp.Models;

namespace Webapp.Controllers
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

        [HttpPost]
        [Authorize()]
        public ActionResult Search(string search)
        {
            IEnumerable<Good> goods = db.Goods.Where(
                r => r.Name.Contains(search) ||
                     r.Supplier.Contains(search)).ToList();

            ViewBag.Goods = goods;

            return View("All");
        }

        [Authorize]
        [HttpPost]
        public ActionResult GoodsList(int pageNum)
        {
            PagedData<Good> pagedGoods = new PagedData<Good>
            {
                Data = db.Goods.OrderBy(r => r.Name).Skip(PageSize * (pageNum - 1)).Take(PageSize).ToList(),
                TotalPages = Convert.ToInt32(Math.Ceiling((double) db.Goods.Count() / PageSize)),
                CurrentPage = pageNum
            };

            return PartialView("GoodsList", pagedGoods);
        }
    }
}