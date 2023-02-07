using System;
using BoxBack.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxBack.Infra.Data.Mappings
{
    public class CredorMap : IEntityTypeConfiguration<Credor>
    {
        public void Configure(EntityTypeBuilder<Credor> builder)
        {
            builder.ToTable("Credores");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();
            
            builder.Property(c => c.TenantId)
                .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                .IsRequired();
            
            builder
                .HasMany(c => c.Despesas)
                .WithOne(c => c.Credor)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}