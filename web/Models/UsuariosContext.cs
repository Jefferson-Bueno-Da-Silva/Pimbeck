using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Pimbeck.Models
{
    public class UsuariosContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options)
        {
        }
    }
}
