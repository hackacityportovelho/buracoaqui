using System;
using System.Web.Mvc;
using Web.App.TapaBuraco.Models;

namespace Web.App.TapaBuraco.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Empresa empresa)
        {
            try
            {
                empresa.PrestadorDeServico = false;
                return RedirectToAction("EmpresasCadastradas");
            }
            catch
            {
                return View("Cadastro", empresa);
            }
        }

        public ActionResult EmpresasCadastradas()
        {
            return View();
        }

        public ActionResult CadastroPrestadorServico()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroPrestadorServico(Empresa empresaPrestadoraDeServico)
        {
            try
            {
                empresaPrestadoraDeServico.PrestadorDeServico = true;
                return RedirectToAction("EmpresasPrestadoresDeServicoCadastradas");
            }
            catch
            {
                return View("CadastroPrestadorServico", empresaPrestadoraDeServico);
            }
        }

        public ActionResult EmpresasPrestadoresDeServicoCadastradas()
        {
            return View();
        }


        public ActionResult AutorizacaoObraPrestadoraServico(Empresa empresa)
        {
            ViewBag.Empresanome = empresa.RazaoSocial;
            ViewBag.Cnpj = empresa.Cnpj ;
            ViewBag.Endereco = empresa.Endereco ;
            ViewBag.Numero = empresa.Numero;
            ViewBag.Bairro = empresa.Bairro;
            return View();
        }
        public ActionResult RequerimentoEmpresaPDF(Empresa empresa , Representante representante)
        {

            //var lista = empresa.RepresentantecCollection(
            //dados da empresa
            ViewBag.Empresanome = empresa.RazaoSocial;
            ViewBag.Cnpj = empresa.Cnpj ;
            ViewBag.Endereco = empresa.Endereco ;
           
            ViewBag.Cep = empresa.Cep ;
            //dados do representante
            ViewBag.Cargo = representante.Cargo ;
            ViewBag.NomeEmpresario = representante.Nome ;
            ViewBag.Cpf = representante.Cpf ;
            ViewBag.Rg = representante.Rg ;
            //lista de buracos adotados
            return View();
        }
    }
}