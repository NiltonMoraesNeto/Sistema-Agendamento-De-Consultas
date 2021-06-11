using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moraes.Models;

namespace Moraes.Controllers
{
    //[Route("api/[controller]")]
    public class LoginController : BaseController
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        //[HttpPost("login")]
        //public IActionResult Login(LoginModel login)
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
                }
            }

            return View();
        }
    }
}
