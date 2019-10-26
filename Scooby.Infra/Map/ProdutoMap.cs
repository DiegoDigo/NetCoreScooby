using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scooby.Domain.Entity;

namespace Scooby.Infra.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.HasOne(p => p.Categoria).WithMany(p => p.produto);
        }
    }
}
