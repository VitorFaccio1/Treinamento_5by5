using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoPendencia.Api.Models;

    public class PendenciaContext : DbContext
    {
        public PendenciaContext (DbContextOptions<PendenciaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoPendencia.Api.Models.Pendencia> Pendencia { get; set; }
    }
