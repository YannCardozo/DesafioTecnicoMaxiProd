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
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Pessoa");

            builder
                .Property(o => o.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.Idade)
                .HasColumnName("Idade")
                .HasColumnType("int");

            //entidade base
            builder.AplicarEntidadeBase();
        }
    }
}
