using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Webapp.Dal;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
        private WarehouseContext db = new WarehouseContext();

        public ActionResult Index()
        {
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в БД
                User user = null;
                user = db.Users.FirstOrDefault(
                    u => u.Login == model.Name &&
                    u.Password == model.Password);


                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
            }

            return View(model);
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}