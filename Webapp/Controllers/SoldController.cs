﻿using System.Linq;
using System.Web.Mvc;
using Webapp.Dal;

namespace Webapp.Controllers
{
    public class SoldController : Controller
    {
        private WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Sold");
        }

        [Authorize()]
        public ActionResult All()
        {
            var goodsForSale = db.Goods.Where(g => g.IsAvailable == false);
            ViewBag.GoodsForSale = goodsForSale;

            return View();
        }
    }
}