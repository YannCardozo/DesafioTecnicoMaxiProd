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
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Categoria");

            builder
                .Property(o => o.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(400);

            builder
                .Property(o => o.Finalidade)
                .HasColumnName("Finalidade")
                .HasColumnType("varchar")
                .HasMaxLength(20);


            //entidade Base
            builder
                .AplicarEntidadeBase();

        }
    }
}
