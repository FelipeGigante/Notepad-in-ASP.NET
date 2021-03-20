using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlocoDeNotas.Models.Entidades
{
    [Table("Caderno")]

    public class Caderno
    {
        public int Id { get; set; }

        [Display(Description = "Texto")]
        public string Texto { get; set; }
    }
}
