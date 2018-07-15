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
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                file.SaveAs(HttpContext.Server.MapPath("~/Upload/")
                                                      + file.FileName);
            }

            var buraco = new Buraco();
            buraco.UriFoto = file.FileName;

            return View("PreencherDados", buraco);
        }

        [HttpPost]
        public ActionResult PreencherDados(Buraco buraco)
        {
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
           // var lista2 = lista.GroupBy(x => x.Bairro).ToList();
            //var lista3 = lista2;
            return View("ListarBuracos",lista);
        }
    }
}