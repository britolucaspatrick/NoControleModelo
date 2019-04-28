using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.Property(p => p.id_categoria).HasColumnName("id_categoria");
            builder.Property(p => p.nome).HasColumnName("nome");

            builder.HasKey(p => p.id_categoria);
        }
    }
}
