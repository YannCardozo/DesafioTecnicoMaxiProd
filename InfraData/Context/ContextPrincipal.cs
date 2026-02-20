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
        //implementar IDENTITY ainda aqui.
        public ContextPrincipal(DbContextOptions<ContextPrincipal> options) : base(options)
        {

        }

        //public dbset entidades, populas as entidades aqui.

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Principal");
            builder.ApplyConfigurationsFromAssembly(typeof(ContextPrincipal).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
