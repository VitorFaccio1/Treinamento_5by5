using Microsoft.EntityFrameworkCore;
using ProjCliente.Models;

namespace ProjCliente.Dal
{
    public class ClienteContext : DbContext
    {
          public ClienteContext (DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

    }
}