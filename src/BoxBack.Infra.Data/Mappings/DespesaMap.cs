using System;
using BoxBack.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxBack.Infra.Data.Mappings
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.ToTable("Despesas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.ValorPrincipal)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.Iof)
                .HasDefaultValue(0)
                .HasColumnType("decimal(7,2)");
            
            builder.Property(c => c.Seguro)
                .HasDefaultValue(0)
                .HasColumnType("decimal(7,2)");
            
            builder.Property(c => c.Tarifa)
                .HasDefaultValue(0)
                .HasColumnType("decimal(7,2)");
            
            builder.Property(c => c.CustoEfetivoTotalAno)
                .HasDefaultValue(0)
                .HasColumnType("decimal(8,6)");

            builder.Property(c => c.CustoEfetivoTotalMes)
                .HasDefaultValue(0)
                .HasColumnType("decimal(8,6)");
            
            builder.Property(c => c.CustoEfetivoTotalDia)
                .HasDefaultValue(0)
                .HasColumnType("decimal(8,6)");

            builder.Property(c => c.ValorEntrada)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.ValorParcelado)
                .HasDefaultValue(0)
                .HasColumnType("decimal(12,2)");
            
            builder.Property(c => c.TenantId)
                .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                .IsRequired();
            
            builder.Property(c => c.ClienteId)
                .HasDefaultValue(null)
                .IsRequired();
            
            builder
                .HasMany(c => c.DespesaParcelas)
                .WithOne(c => c.Despesa)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasOne(x => x.Cliente)
                .WithMany(x => x.Despesas)
                .HasForeignKey(x => x.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}