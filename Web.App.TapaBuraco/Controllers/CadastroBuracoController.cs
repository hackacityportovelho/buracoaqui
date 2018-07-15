using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.App.TapaBuraco.Controllers
{
    public class CadastroBuracoController : Controller
    {
        // GET: CadastroBuraco
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PreencherDados(string uriFoto)
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult PreencherDados()
        {


            return View("Index");
        }

        [HttpPost]
        public ActionResult ConfirmarFoto(string uriFoto)
        {
            ViewBag.UriImg = uriFoto;

            return PartialView("_ConfirmarFoto");
        }
    }
}