using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moraes.Models;
using Moraes.Uteis;
using Newtonsoft.Json;

namespace Moraes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet("Login")]
        public IActionResult Login()
        {         
            
            return View();
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                bool loginOK = login.ValidarLogin();
                if (loginOK)
                {
                    List<Claim> claims = new List<Claim>()
                            {
                                new Claim("Id", login.IdUsuario.ToString(), ClaimValueTypes.Integer),
                                new Claim("Nome", login.Nome, ClaimValueTypes.String),
                                new Claim("IdLicenca", login.IdLicenca.ToString(), ClaimValueTypes.Integer)
                            };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Calendario");
                }
                else
                {
                    TempData["ErrorLogin"] = "Email ou Senha Inválidos!";
                    return RedirectToAction("", "Login");
                }
            }            

            return View();
        }

        [HttpGet]
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
