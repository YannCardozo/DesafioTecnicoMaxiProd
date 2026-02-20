using Dominio.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Mappings
{
    public static class EntidadeBaseMapping
    {
        public static void AplicarEntidadeBase<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : EntidadeBase<Guid>
        {
            builder
                .Property(o => o.Id)
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder
                .Property(o => o.DataCadastro)
                .HasColumnType("datetime2")
                .HasColumnName("DataCadastro");

            builder
                .Property(o => o.DataAtualizacao)
                .HasColumnType("datetime2")
                .HasColumnName("DataAtualizacao");

            builder
                .Property(o => o.QuemCadastrou)
                .HasColumnType("uniqueidentifier")
                .HasColumnName("QuemCadastrou");

            builder
                .Property(o => o.AtualizouPorUltimo)
                .HasColumnType("uniqueidentifier")
                .HasColumnName("AtualizouPorUltimo");

        }
    }
}
