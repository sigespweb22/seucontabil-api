using System;
using BoxBack.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxBack.Infra.Data.Mappings
{
    public class DespesaParcelaMap : IEntityTypeConfiguration<DespesaParcela>
    {
        public void Configure(EntityTypeBuilder<DespesaParcela> builder)
        {
            builder.ToTable("DespesasParcelas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.SaldoInicial)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.SaldoFinal)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.Juros)
                .HasDefaultValue(0)
                .HasColumnType("decimal(10,6)");
            
            builder.Property(c => c.Amortizacao)
                .HasDefaultValue(0)
                .HasColumnType("decimal(10,6)");
            
            builder.Property(c => c.ValorParcela)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.TenantId)
                .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                .IsRequired();
            
            builder
                .HasOne(c => c.Despesa)
                .WithMany(c => c.DespesaParcelas)
                .HasForeignKey(c => c.DespesaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}