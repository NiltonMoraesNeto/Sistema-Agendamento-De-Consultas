using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moraes.Models;
using Moraes.Uteis;
using Newtonsoft.Json;

namespace Moraes.Controllers
{
    public class CalendarioController : BaseController
    {

        // GET: CalendarioController
        [HttpGet]
        public IActionResult Index()
        {
            int idlicenca = UserAuth.IdLicenca;

            List<CalendarioModel> lista = new CalendarioModel().RetornarConsulta(idlicenca);
            List<object> eventos = new List<object>();

            for (int i = 0; i < lista.Count; i++)
            {
                eventos.Add(new
                {

                    title = lista[i].Assunto + " - " + lista[i].Descricao,
                    start = lista[i].Start.ToString(),
                    end = lista[i].End.ToString(),
                    color = lista[i].Color.ToString(),
                    url = "/Calendario/Cadastro/" + lista[i].Id.ToString()
                });
            }
            ViewBag.Eventos = eventos;        

            return View();
        }

        // GET: CalendarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalendarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalendarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalendarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalendarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {

            if (id != null)
            {
                //Carregar os dados na ViewBag
                ViewBag.Calendar = new CalendarioModel().RetornarCadastroCalendar(id);
            }
            CarregarDados();

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(CalendarioModel calendar)
        {
            if (ModelState.IsValid)
            {
                int idlicenca = UserAuth.IdLicenca;
                calendar.IdLicenca = idlicenca.ToString();
                calendar.Gravar(idlicenca);
                CarregarDados();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Excluir(int id)
        {
            ViewData["IdExcluir"] = id;
            return View();
        }

        public IActionResult ExcluirCalendario(int id)
        {
            new CalendarioModel().Excluir(id);
            return View();
        }

        // GET: CalendarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalendarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Lista()
        {
            int idlicenca = UserAuth.IdLicenca;
            ViewBag.Calendar = new CalendarioModel().ListarTodosConsultas(idlicenca);
            return View();
        }

        private void CarregarDados()
        {
            int idlicenca = UserAuth.IdLicenca;
            ViewBag.ListaUsuario = new CalendarioModel().RetornarListaUsuario(idlicenca);
        }
    }
}
