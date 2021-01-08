using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDashboards.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Infra.Data.Mappings
{
    public class MovimentacaoFinanceiraMap 
        : IEntityTypeConfiguration<MovimentacaoFinanceira>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoFinanceira> builder)
        {
            builder.ToTable("MovimentacaoFinanceira");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("Id");

            builder.Property(m => m.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(m => m.Data)
                .HasColumnName("Data")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(m => m.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(m => m.TipoMovimentacao)
                .HasColumnName("TipoMovimentacao")
                .IsRequired();
        }
    }
}
