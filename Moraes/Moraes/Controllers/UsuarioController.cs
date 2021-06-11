using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moraes.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Razor;
using Moraes.Extension;

namespace Moraes.Controllers
{
    public class UsuarioController : BaseController
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public UsuarioController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int idlicenca = UserAuth.IdLicenca;
            ViewBag.Listausuarios = new UsuarioModel().ListagemUsuarios(idlicenca);
            
            return View();
        }

        [HttpGet]
        public IActionResult Account()
        {
            //CarregarDados();
            //UsuarioModel usuario = new UsuarioModel().RetornarUsuario(IdUsuario);
            //return View(usuario);
            //UsuarioModel usuario, [FromForm] IFormFileCollection Foto
            //ViewBag.Tree = "~/FotoPerfil/" + Foto;

            int id = UserAuth.Id;
            ViewBag.Listausuarios2 = new UsuarioModel().ListagemUsuarios2(id);            

            return View();
        }

        [HttpGet]
        public IActionResult Cadastro([FromRoute] int? IdUsuario)
        {
            CarregarDados();

            if (IdUsuario != null)
            {
                //Carregar os dados na ViewBag
                //ViewBag.Usuario = new UsuarioModel().RetornarUsuario(IdUsuario);
                UsuarioModel usuario = new UsuarioModel().RetornarUsuario(IdUsuario);
                return View(usuario);
            }
            
            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastro(UsuarioModel usuario, [FromForm]IFormFileCollection Foto)
        {
            
            if (ModelState.IsValid)
            {
                int idlicenca = UserAuth.IdLicenca;
                usuario.IdLicenca = idlicenca.ToString();

                foreach (IFormFile file in Foto)
                {
                    System.IO.File.WriteAllBytes("FotoPerfil/" + file.FileName, file.GetBytes());
                    //File.WriteAllBytes("Foo.txt", file.GetBytes());
                    usuario.Foto = file.FileName;
                }

                usuario.Gravar();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Excluir(int IdUsuario)
        {
            ViewData["IdExcluir"] = IdUsuario;
            return View();
        }

        public IActionResult ExcluirUsuario(int IdUsuario)
        {
            new UsuarioModel().Excluir(IdUsuario);
            return View();
        }

        private void CarregarDados()
        {
            ViewBag.ListaPerfils = new UsuarioModel().RetornarListaPerfil();
            ViewBag.ListaLicencas = new UsuarioModel().RetornarListaLicenca();
        }
    }
}