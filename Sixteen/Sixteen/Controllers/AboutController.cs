using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sixteen.Data;
using Sixteen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout();
            model.settings = _context.Settings.FirstOrDefault();
            model.socials = _context.Socials.ToList();
            //model.members = _context.Members.Include("Majors").ToList();

            model.workCards = _context.WorkCards.ToList();

            model.costumers = _context.Costumers.ToList();

            model.head = _context.Heads.ToList().ElementAt(1);
            return View(model);
        }
    }
}
