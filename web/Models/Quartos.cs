using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Pimbeck.Models
{
    [Table("quartos")]
    public class Quartos
    {
        [Key]

        public int id_quarto { get; set; }
        public string numero_quarto { get; set; }
        public int qtd_pessoas { get; set; }
        public int id_categoria_quarto { get; set; }



    }
}
