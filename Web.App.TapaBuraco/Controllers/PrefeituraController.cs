using System;
using System.Web.Mvc;
using Web.App.TapaBuraco.Models;

namespace Web.App.TapaBuraco.Controllers
{
    public class PrefeituraController : Controller
    {
        private Contexto dbContexto = new Contexto();

        // GET: Prefeitura
        public ActionResult Cadastro()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Prefeitura prefeitura)
        {
            try
            {
                dbContexto.Prefeitura.Add(prefeitura);
                dbContexto.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View("Cadastro", prefeitura);
            }
        }


    }
}