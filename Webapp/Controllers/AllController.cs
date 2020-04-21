using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Webapp.Dal;
using Webapp.Helpers;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class AllController : Controller
    {
        private static readonly int PageSize = 3;
        
        private WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            PagedData<Good> pagedGoods = new PagedData<Good>
            {
                Data = db.Goods.OrderBy(r => r.Name).Skip(PageSize * 0).Take(PageSize).ToList(),
                TotalPages = Convert.ToInt32(Math.Ceiling((double)db.Goods.Count() / PageSize)),
                CurrentPage = 1
            };

            return View(pagedGoods);
        }

        [Authorize()]
        public ActionResult All()
        {
            return RedirectToAction("Index");
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
        
        [Authorize]
        public ActionResult GetAvailability(int id)
        {
            Good good = db.Goods.Find(id);
            return PartialView(good);
        }
    }
}