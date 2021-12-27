using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class WorkCard
    {
        [Key]
        public int Int { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="ntext")]
        public string Info { get; set; }

        [MaxLength(20)]
        public string Button { get; set; }
    }
}
