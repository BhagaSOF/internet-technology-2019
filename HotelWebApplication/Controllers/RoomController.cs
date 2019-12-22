using HotelWebApplication.Dal;
using HotelWebApplication.Models;
using HotelWebApplication.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System;

namespace HotelWebApplication.Controllers
{
    public class RoomController : Controller
    {
        private WarehouseContext db = new WarehouseContext();

        [Authorize()]
        public ActionResult Index()
        {
            return RedirectToAction("All", "Room");
        }

        [HttpGet]
        [Authorize()]
        public ActionResult All()
        {
            IEnumerable<Room> rooms = db.Rooms;
            ViewBag.Rooms = rooms;

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

            Room room = db.Rooms.Find(id);
            if (room != null)
            {
                return View(room);
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Room model, HttpPostedFileBase imageData)
        {
            if (imageData != null)
                model.PhotoUrl = ImageSaveHelper.SaveImage(imageData);

            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("All");
            }

            return View("Edit", model);
        }
        #endregion /редактирование

        [HttpGet]
        [Authorize()]
        public ActionResult Book(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Room room = db.Rooms.Find(id);
            if (room != null)
            {
                ViewBag.RoomId = room.Id;

                return View();
            }

            return HttpNotFound();
        }

        [HttpPost]
        [Authorize()]
        public ActionResult Book(Item model)
        {
            model.BookingDateTime = DateTime.Now;

            #region проверка номера комнаты
            Room room = db.Rooms.
                FirstOrDefault(
                r => r.Id == model.IsAvailable);

            if (room == null)
            {
                ModelState.AddModelError(string.Empty, "Комната под таким номером не существует");
                return View("Book", model);
            }

            #endregion /проверка номера комнаты

            #region проверка клиента
            Client client = db.Clients.
                FirstOrDefault(
                c => c.PassportSeriesAndNumber == model.Name);

            if (client == null) // если нет такого -- создаём
            {
                int passportSeriesAndNumber = model.Name;
                string fullName = model.Supplier;
                Client c = new Client
                {
                    PassportSeriesAndNumber = passportSeriesAndNumber,
                    FullName = fullName
                };

                db.Clients.Add(c);
            }
            else // если есть -- проверяем ФИО
            {
                if (client.FullName != model.Supplier)
                {
                    ModelState.AddModelError(string.Empty, "ФИО клиента не соответсвует серии и номеру паспорта в базе");
                    model.Supplier = client.FullName;
                    return View("Book", model);
                }
            }
            #endregion /проверка клиента

            db.Bookings.Add(model);
            db.SaveChanges();

            return RedirectToAction("All", "Room");
        }
    }
}