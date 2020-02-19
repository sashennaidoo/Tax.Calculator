using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Calculator.Domain.Entities.Reference;

namespace Tax.Calculator.Data.EntityConfiguration
{
    public class TaxValueConfiguration : IEntityTypeConfiguration<TaxValue>
    {
        public TaxValueConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<TaxValue> builder)
        {
            builder.ToTable("TR_TXV_Tax_Value");

            builder.HasKey(t => t.Code).HasName("txv_code");
            builder.Property(p => p.Code).ValueGeneratedOnAdd();

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnName("txv_description")
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("txv_value")
                .HasColumnType("varchar(20)");

        }
    }
}
