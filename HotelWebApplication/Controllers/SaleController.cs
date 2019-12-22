﻿using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HotelWebApplication.Controllers
{
    public class SaleController : Controller
    {
        private WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Sale");
        }

        [Authorize()]
        public ActionResult All()
        {
            var goodsForSale = db.Goods.Where(g => g.IsAvailable == true);
            ViewBag.GoodsForSale = goodsForSale;

            return View();
        }

        #region редактирование
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Good good = db.Goods.Find(id);
            if (good != null && good.IsAvailable == true)
            {
                return View(good);
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Good model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("All", "Sale");
            }

            return View("Edit", model);
        }
        #endregion /редактирование

        [HttpGet]
        [Authorize()]
        public ActionResult Delete(int id)
        {
            Good g = db.Goods.Find(id);

            if (g == null || g.IsAvailable == false)
                return HttpNotFound();
            else
            {
                db.Goods.Remove(g);
                db.SaveChanges();
            }

            return RedirectToAction("All", "Sale");
        }
    }
}