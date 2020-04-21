﻿using System.Collections.Generic;
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

            return PartialView(goods);
        }
    }
}