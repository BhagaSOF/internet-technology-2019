using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using System.Collections.Generic;
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
            IEnumerable<Item> bookings = db.Bookings;
            ViewBag.Bookings = bookings;

            return View();
        }

        [HttpGet]
        [Authorize()]
        public ActionResult Delete(int id)
        {
            Item b = db.Bookings.Find(id);

            if (b == null)
                return HttpNotFound();
            else
            {
                db.Bookings.Remove(b);
                db.SaveChanges();
            }

            return RedirectToAction("All", "Hotel");
        }
    }
}