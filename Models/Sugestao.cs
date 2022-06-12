using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Simbora04.Models
{
    [Table("Sugestao")]
    public class Sugestao
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Sugestão")]
        public string Sugestoes { get; set; }
    }
}
