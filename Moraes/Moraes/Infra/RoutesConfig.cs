using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moraes.Infra
{
    public class RoutesConfig
    {
        public RoutesConfig(IEndpointRouteBuilder routes)
        {
            //Default
            routes.MapControllerRoute("login", "", new { controller = "Login", action = "Login" });
            routes.MapControllerRoute("Logout", "", new { controller = "Logout", action = "Logout" });
            routes.MapControllerRoute("calendario", "calendario", new { controller = "Calendario", action = "Index" });
            routes.MapControllerRoute("calendario", "calendario/cadastro", new { controller = "Calendario", action = "Cadastro" });
            routes.MapControllerRoute("cliente", "cliente", new { controller = "Cliente", action = "Index" });
            routes.MapControllerRoute("cliente", "cliente/cadastro", new { controller = "Cliente", action = "Cadastro" });
            routes.MapControllerRoute("cliente", "cliente/cadastro/{IdCliente}", new { controller = "Cliente", action = "Cadastro" });
            routes.MapControllerRoute("cliente", "cliente/excluir/{IdCliente}", new { controller = "Cliente", action = "Excluir" });
            routes.MapControllerRoute("cliente", "cliente/excluircliente/{IdCliente}", new { controller = "Cliente", action = "ExcluirCliente" });
            routes.MapControllerRoute("usuario", "usuario", new { controller = "Usuario", action = "Index" });
            routes.MapControllerRoute("usuario", "usuario/cadastro", new { controller = "Usuario", action = "Cadastro" });
            routes.MapControllerRoute("usuario", "usuario/cadastro/{IdUsuario}", new { controller = "Usuario", action = "Cadastro" });
            routes.MapControllerRoute("usuario", "usuario/account", new { controller = "Usuario", action = "Account" });
            routes.MapControllerRoute("usuario", "usuario/excluir/{IdUsuario}", new { controller = "Usuario", action = "Excluir" });
            routes.MapControllerRoute("usuario", "usuario/excluirusuario/{IdUsuario}", new { controller = "Usuario", action = "ExcluirUsuario" });
        }
    }
}
