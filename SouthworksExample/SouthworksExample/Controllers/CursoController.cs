using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SouthworksExample.Controllers
{
    public class CursoController : Controller
    {
        //
        // GET: /Curso/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FindAll()
        {
            //LLamo al metodo.
            new CursoServices.CursoServices().FindAll();

            var resultado = new SouthworksExample.Models.EventModel()
             {
                 Id = Guid.NewGuid(),
                 Title = "pruebita",
                 StartDate = DateTime.Now,
                 Technology = "Desarrollo",
                 RegistrationLink = @"http://www.google.com.ar"
             };
            return View(resultado);
        }

    }
}
