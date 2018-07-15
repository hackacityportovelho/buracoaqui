using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public ActionResult VisualizarDetalhes(Guid empresaId)
        {
            var empresa = db.Empresa.FirstOrDefault(e=>e.Id == empresaId);

            //var lista = empresa.RepresentantecCollection(
            //dados da empresa
            ViewBag.Empresanome = empresa.RazaoSocial;
            ViewBag.Cnpj = empresa.Cnpj;
            ViewBag.Endereco = empresa.Endereco;

            ViewBag.Cep = empresa.Cep;
            //dados do representante
            ViewBag.Cargo = "";
            ViewBag.NomeEmpresario = "";
            ViewBag.Cpf = "";
            ViewBag.Rg = "";
            //lista de buracos adotados

            return View("RequerimentoEmpresaPDF");

        }

        public ActionResult Aprovar(Guid empresaId)
        {
            var empresa = db.Empresa.FirstOrDefault(e => e.Id == empresaId);


            ViewBag.Empresanome = empresa.RazaoSocial;
            ViewBag.Cnpj = empresa.Cnpj;
            ViewBag.Endereco = empresa.Endereco;
            ViewBag.Numero = empresa.Numero;
            ViewBag.Bairro = empresa.Bairro;

            return View("AutorizacaoObraPrestadoraServico");
        }
    }
}