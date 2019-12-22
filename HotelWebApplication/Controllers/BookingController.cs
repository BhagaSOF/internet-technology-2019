﻿using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HotelWebApplication.Controllers
{
    public class BookingController : Controller
    {
        private HotelContext db = new HotelContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Booking");
        }

        [Authorize()]
        public ActionResult All()
        {
            IEnumerable<Booking> bookings = db.Bookings;
            ViewBag.Bookings = bookings;

            return View();
        }

        [HttpGet]
        [Authorize()]
        public ActionResult Delete(int id)
        {
            Booking b = db.Bookings.Find(id);

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