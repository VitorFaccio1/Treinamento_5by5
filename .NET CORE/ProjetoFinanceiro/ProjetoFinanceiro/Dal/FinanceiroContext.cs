using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Models;

namespace ProjetoFinanceiro.Dal
{
    public class FinanceiroContext : DbContext
    {
        public FinanceiroContext(DbContextOptions<FinanceiroContext> options ) : base(options)
        {
            
        }

        public DbSet<Cliente> Cliente {get;set;}

        public DbSet<ContaCorrente> ContaCorrente {get;set;}
    }
}