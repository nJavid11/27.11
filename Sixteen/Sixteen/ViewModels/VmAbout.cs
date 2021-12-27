using Sixteen.Data;
using Sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.ViewModels
{
    public class VmAbout
    {
        public Setting settings { get; set; }

        public List<Social> socials { get; set; }

        public List<Member> members { get; set; }
        public List<Major> majors { get; set; }

        public List<WorkCard> workCards { get; set; }

        public List<Costumer> costumers { get; set; }

        public Head head { get; set; }
    }
}
