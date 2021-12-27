using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sixteen.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName ="ntext")]
        public string Info { get; set; }

        [MaxLength(5)]
        public int Star { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //[Column(TypeName = "ntext")]
        //public string Image { get; set; }
    }
}
