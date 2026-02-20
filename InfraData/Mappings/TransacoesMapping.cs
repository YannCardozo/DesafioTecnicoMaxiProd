using Dominio.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Mappings
{
    public class TransacoesMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("Transacoes");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Transacao");

            builder
                .Property(o => o.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(300);

            builder
                .Property(o => o.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal");

            builder
                .Property(o => o.Tipo)
                .HasColumnName("Tipo")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            //entidade base
            builder.AplicarEntidadeBase();
        }
    }
}
