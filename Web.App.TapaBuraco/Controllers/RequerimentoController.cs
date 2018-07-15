using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.App.TapaBuraco.Models;

namespace Web.App.TapaBuraco.Controllers
{
    public class RequerimentoController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Requerimento
        public ActionResult Index()
        {
            var empresas = db.Empresa.ToList();

            var listaRetorno = new List<Empresa>();

            foreach (var item in empresas)
            {
                item.BuracoCollection = db.Buraco.Where(b=>b.IdEmpresa == item.Id).ToList();

                if (item.BuracoCollection.Count != 0)
                {
                    listaRetorno.Add(item);
                }
            }

            return View(listaRetorno);
        }
    }
}