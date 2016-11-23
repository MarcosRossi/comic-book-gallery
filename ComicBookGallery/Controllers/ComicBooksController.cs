using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Details()
        {
            ViewBag.Title = "Spiderman registred";
            ViewBag.Description = "Zarpado libro papa";
            ViewBag.Artists = new string[] { "Parker", "Jane", "Peter", "Mary" };
            return View();
        }

    }
}