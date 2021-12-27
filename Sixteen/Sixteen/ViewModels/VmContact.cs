using Sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.ViewModels
{
    public class VmContact
    {
        public List<Social> socials { get; set; }
        public Setting setting { get; set; }
        public List<Accordion> accordions { get; set; }
        public List<Costumer> costumers { get; set; }

        public Head head { get; set; }
    }
}
