using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="ntext")]
        public string Info { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        [ForeignKey("Major")]
        public int MajorId { get; set; }
        public Major Major { get; set; }
    }
}
