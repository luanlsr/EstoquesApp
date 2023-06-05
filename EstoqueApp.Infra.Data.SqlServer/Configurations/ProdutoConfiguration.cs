using EstoqueApp.Domain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.SqlServer.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Preco).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(e => e.Quantidade).IsRequired();
            builder.Property(e => e.EstoqueId).IsRequired();

            builder.HasOne(p => p.Estoque)
                .WithMany(e => e.Produtos).HasForeignKey(e => e.EstoqueId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
