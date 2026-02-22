using Dominio.DAO;
using Dominio.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Context
{
    public class ContextPrincipal : IdentityDbContext<Usuario, IdentityRole<Guid>, Guid>
    {
        public ContextPrincipal(DbContextOptions<ContextPrincipal> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Principal");
            builder.ApplyConfigurationsFromAssembly(typeof(ContextPrincipal).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
