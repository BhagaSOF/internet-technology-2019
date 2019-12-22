using HotelWebApplication.Dal;
using HotelWebApplication.Models;
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