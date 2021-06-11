using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moraes.Infra;

namespace Moraes.Controllers
{
    public class BaseController : Controller
    {
        public IUser UserAuth { get; }

        public BaseController()
        {
            UserAuth = ServiceLocators.Get<IUser>();
        }
    }
}
