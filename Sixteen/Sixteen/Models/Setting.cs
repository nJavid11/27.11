using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string AboutTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string AboutContent { get; set; }

        [MaxLength(50)]
        public string Copyright { get; set; }

        [Column(TypeName ="ntext")]
        public string BgText { get; set; }

        [MaxLength(200)]
        public string BgImage { get; set; }

        [MaxLength(50)]
        public string BgTitle { get; set; }
    }
}
