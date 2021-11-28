using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Pimbeck.Models
{
    public class CategoriaQuartoContext : DbContext
    {
        public DbSet<Categoria> CategoriaQuarto { get; set; }

        public CategoriaQuartoContext(DbContextOptions<CategoriaQuartoContext> options) : base(options)
        {
        }
    }
}
