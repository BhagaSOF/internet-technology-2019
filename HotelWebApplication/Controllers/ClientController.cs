using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HotelWebApplication.Controllers
{
    public class ClientController : Controller
    {
        private HotelContext db = new HotelContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Client");
        }

        [Authorize()]
        public ActionResult All()
        {
            IEnumerable<Client> clients = db.Clients;
            ViewBag.Clients = clients;

            return View();
        }
    }
}