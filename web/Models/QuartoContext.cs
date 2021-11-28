using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pimbeck.Models
{
    public class QuartoContext:DbContext
    {
        public DbSet<Quartos> Quartos { get; set; }

        public QuartoContext(DbContextOptions<QuartoContext> options) : base(options) 
        { 
        }


    }
}
