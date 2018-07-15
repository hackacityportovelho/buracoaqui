using System.Linq;
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
            return View();
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

            return View();
        }
    }
}