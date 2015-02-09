using LaPlumaDeAsis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaPlumaDeAsis.Controllers
{
    public class HomeController : Controller
    {
        LaPlumaDeAsisDb _db = new LaPlumaDeAsisDb();

        public ActionResult Index()
        {

            return View();
        }

        [Authorize]
        public ActionResult AdminCatalogo()
        {
            var model = _db.Cuchillos.ToList();
            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LaPluma()
        {
            return View();
        }

        public ActionResult ElAutor()
        {
            return View();
        }

    }
}