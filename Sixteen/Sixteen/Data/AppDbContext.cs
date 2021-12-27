using Microsoft.EntityFrameworkCore;
using Sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Accordion> Accordions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Head> Heads { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<WorkCard> WorkCards { get; set; }
    }
}
