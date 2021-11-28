using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Pimbeck.Models
{
    [Table("categoria_quarto")]
    public class Categoria
    {
        [Key]

        public int id_categoria_quarto { get; set; }
        public string nome_categoria_quarto { get; set; }
        public int qtd_camas { get; set; }
        public int valor_categoria_quarto { get; set; }



    }
}
