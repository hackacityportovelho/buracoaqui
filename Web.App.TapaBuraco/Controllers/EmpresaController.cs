using System;
using System.Linq;
using System.Web.Mvc;
using Web.App.TapaBuraco.Models;

namespace Web.App.TapaBuraco.Controllers
{
    public class EmpresaController : Controller
    {
        private Contexto dbContexto = new Contexto();
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
                dbContexto.Empresa.Add(empresa);
                empresa.Representante.IdEmpresa = empresa.Id;
                dbContexto.Representante.Add(empresa.Representante);
                dbContexto.SaveChanges();
                return RedirectToAction("EmpresasCadastradas");
            }
            catch (Exception e)
            {
                var teste = e;
                return View("Cadastro", empresa);
            }
        }

        public ActionResult EmpresasCadastradas()
        {
            var listaDeEmpresa = dbContexto.Empresa.Where(x => x.PrestadorDeServico == false);
            return View("EmpresasCadastradas", listaDeEmpresa);
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
                dbContexto.Empresa.Add(empresaPrestadoraDeServico);
                empresaPrestadoraDeServico.Representante.IdEmpresa = empresaPrestadoraDeServico.Id;
                dbContexto.Representante.Add(empresaPrestadoraDeServico.Representante);
                dbContexto.SaveChanges();
                return RedirectToAction("EmpresasPrestadoresDeServicoCadastradas");
            }
            catch
            {
                return View("CadastroPrestadorServico", empresaPrestadoraDeServico);
            }
        }

        public ActionResult EmpresasPrestadoresDeServicoCadastradas()
        {
            var listaEmpresaPrestadoresDeServico = dbContexto.Empresa.Where(x => x.PrestadorDeServico);
            return View("EmpresasPrestadoresDeServicoCadastradas", listaEmpresaPrestadoresDeServico);
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