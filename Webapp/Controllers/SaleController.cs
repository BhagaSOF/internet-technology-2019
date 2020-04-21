using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Webapp.Dal;
using Webapp.Models;

namespace Webapp.Controllers
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

        #region пометить проданным
        [HttpGet]
        [Authorize()]
        public ActionResult Sold(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Good good = db.Goods.Find(id);
            if (good != null && good.IsAvailable == true)
            {
                good.IsAvailable = false;
                db.Entry(good).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("All", "Sale");
            }

            return HttpNotFound();
        }
        #endregion /пометить проданным




        #region редактирование
        [HttpGet]
        [Authorize()]
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

        #region добавление
        [HttpGet]
        [Authorize()]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize()]
        public ActionResult Add(Good model)
        {
            db.Goods.Add(model);
            db.SaveChanges();

            return RedirectToAction("All", "Sale");
        }
        #endregion /добавление
    }
}