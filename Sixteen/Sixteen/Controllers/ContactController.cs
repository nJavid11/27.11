using Microsoft.AspNetCore.Mvc;
using Sixteen.Data;
using Sixteen.Models;
using Sixteen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new VmContact();

            model.setting = _context.Settings.FirstOrDefault();
            model.socials = _context.Socials.ToList();
            model.accordions = _context.Accordions.ToList();
            model.costumers = _context.Costumers.ToList();
            model.head = _context.Heads.ToList().ElementAt(2);

            return View(model);
        }
    }
}
