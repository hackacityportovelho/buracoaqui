using System;
using System.Data.Entity.Migrations;
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
            var lista = db.Buraco.Where(x => x.Resolvido == false && x.IdEmpresa == null).OrderBy(x => x.Bairro).ToList();
            return View("ListarBuracos",lista);
        }

        [HttpPost]
        public ActionResult Detalhes(string rua, string bairro)
        {
            var listaBuracos = db.Buraco.Where(x =>
                x.Rua == rua && x.Bairro == bairro && x.IdEmpresa == null && x.Resolvido == false);

            ViewBag.Empresa = new SelectList(db.Empresa.Where(x => x.PrestadorDeServico == false), "Id", "RazaoSocial", "Selecione");

            return View("AdotarBuracos", listaBuracos);
        }

        public ActionResult AdotarBuraco(string bairro, string rua, Guid empresa)
        {
            var listaBuracos = db.Buraco.Where(x =>
                x.Rua == rua && x.Bairro == bairro && x.IdEmpresa == null && x.Resolvido == false).ToList();


            foreach (var buraco in listaBuracos)
            {
                buraco.IdEmpresa = empresa;
                db.Buraco.AddOrUpdate(buraco);

            }

            db.SaveChanges();

            ViewBag.Mensagem = "Buraco adotado com sucesso";
            return View("Mensagem");
        }
    }
}