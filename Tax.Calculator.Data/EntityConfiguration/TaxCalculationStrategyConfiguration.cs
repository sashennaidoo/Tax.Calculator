using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Calculator.Domain.Entities.Reference;

namespace Tax.Calculator.Data.EntityConfiguration
{
    public class TaxCalculationStrategyConfiguration : IEntityTypeConfiguration<TaxCalculationStrategy>
    {
        public void Configure(EntityTypeBuilder<TaxCalculationStrategy> builder)
        {
            builder.ToTable("TR_TXS_Tax_Strategy");

            builder.HasKey(t => t.Code);
            builder.Property(p => p.Code).ValueGeneratedOnAdd();

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnName("txs_description")
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("txs_name")
                .HasColumnType("varchar(20)");
        }
    }
}
