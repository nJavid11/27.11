using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class Costumer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(200)]
        public string Link { get; set; }
    }
}
