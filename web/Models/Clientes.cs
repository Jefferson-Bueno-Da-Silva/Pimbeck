using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pimbeck.Models
{
    [Table("clientes")]

    public class Clientes
    {
        [Key]
        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string sobrenome_cliente { get; set; }
        public string cpf_cliente { get; set; }
        public string email_cliente { get; set; }
        public string telefone_cliente { get; set; }
        public string rg_cliente { get; set; }
    }
}