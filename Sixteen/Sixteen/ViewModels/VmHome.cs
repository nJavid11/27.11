using Sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.ViewModels
{
    public class VmHome
    {
        public List<Product> products { get; set; }
        public Setting Setting { get; set; }

        public List<Slider> sliders { get; set; }
    }
}
