using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sixteen.Data;
using Sixteen.Models;
using Sixteen.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome();
            model.products = _context.Products.ToList();
            model.sliders = _context.Sliders.ToList();

            return View(model);
        }
    }
}
