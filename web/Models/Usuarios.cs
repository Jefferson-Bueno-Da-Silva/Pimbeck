using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Pimbeck.Models
{
    [Table("usuarios")]

    public class Usuarios
    {
        [Key]

        public int id_usuario { get; set; }
        public string email_usuario { get; set; }
        public string senha_usuario { get; set; }
        public int id_funcionario { get; set; }
        
    }
}
