using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Pimbeck.Models
{
    public class ReservasContext : DbContext
    {
        public DbSet<Reservas> Reservas { get; set; }

        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options)
        {
        }
    }
}
