using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pimbeck.Models
{
    [Table("reservas")]
    public class Reservas
    {
        [Key]
        public int id_reserva { get; set; }
        public DateTime data_entrada { get; set; }
        public DateTime data_saida { get; set; }
        public int id_quarto { get; set; }
        public int? id_cliente { get; set; }
        public int? id_funcionario { get; set; }
        public int? id_user { get; set; }
        public Boolean checkin { get; set; }

    }
}
