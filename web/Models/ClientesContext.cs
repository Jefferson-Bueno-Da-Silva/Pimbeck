using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Pimbeck.Models
{
    public class ClientesContext:DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {
        }
    }
}
