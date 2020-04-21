using System.Collections.Generic;
using System.Web.Mvc;
using Webapp.Dal;
using Webapp.Models;
using System.Data.Entity;
using System.Linq;

namespace Webapp.Controllers
{
    public class FindController : Controller
    {
        private readonly WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Find");
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