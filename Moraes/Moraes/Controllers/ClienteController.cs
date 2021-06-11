using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moraes.Infra;
using Moraes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Moraes.Controllers
{
    public class ClienteController : BaseController
    {

        [HttpGet]
        public IActionResult Index()
        {
            int idlicenca = UserAuth.IdLicenca;
            ViewBag.ListaClientes = new ClienteModel().ListarTodosClientes(idlicenca);
            return View();
        }
        [HttpGet]
        public IActionResult Cadastro([FromRoute] int? IdCliente)
        {

            if (IdCliente != null)
            {
                //Carregar os dados na ViewBag
                ClienteModel cliente = new ClienteModel().RetornarCliente(IdCliente);
                return View(cliente);
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                int idlicenca = UserAuth.IdLicenca;
                cliente.IdLicenca = idlicenca.ToString();
                //cliente.DataNascimento = Convert.ToDateTime("yyyy-MM-dd HH:mm:ss:fff");
                //string dataNascimento = cliente.DataNascimento;
                //dataNascimento = Convert.ToDateTime("yyyy-MM-dd").ToString();

                //string dateString = cliente.DataNascimento;
                //dateString = (Convert.ToDateTime(collection["DataNascimento"]).ToString());

                cliente.Gravar();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Excluir(int IdCliente)
        {
            ViewData["IdExcluir"] = IdCliente;
            return View();
        }

        public IActionResult ExcluirCliente(int IdCliente)
        {
            new ClienteModel().Excluir(IdCliente);
            return View();
        }
    }
}