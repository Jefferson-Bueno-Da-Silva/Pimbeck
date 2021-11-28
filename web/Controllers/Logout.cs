using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pimbeck.Controllers
{
    public class Logout : Controller
    {
        [Authorize]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
