using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.App.TapaBuraco.Models;

namespace Web.App.TapaBuraco.Controllers
{
    public class CadastroBuracoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: CadastroBuraco
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PreencherDados()
        {
            ViewBag.UriImg = TempData["uriFoto"];
            TempData.Keep("uriFoto");
            return View();
        }

        [HttpPost]
        public ActionResult PreencherDados(Buraco buraco)
        {
            var img = (string)TempData["uriFoto"];
            buraco.UriFoto = Convert.FromBase64String(img);
            db.Buraco.Add(buraco);
            db.SaveChanges();

            return View("Index");
        }

        [HttpPost]
        public ActionResult ConfirmarFoto(string uriFoto)
        {
            ViewBag.UriImg = uriFoto;

            return PartialView("_ConfirmarFoto");
        }

        public ActionResult ListarBuracos()
        {
            var lista = db.Buraco.Where(x => x.Resolvido == false).OrderBy(x => x.Bairro).ToList();
            ViewBag.rua = lista.Where(x => x.Resolvido == false).Select(x => x.Rua).Distinct();

           // var lista2 = lista.GroupBy(x => x.Bairro).ToList();
            //var lista3 = lista2;
            return View();
        }
    }
}