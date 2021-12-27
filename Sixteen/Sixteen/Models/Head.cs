using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class Head
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Uptitle { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }
    }
}
