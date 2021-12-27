using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        [Area("admin")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
