using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Calculator.Domain.Entities.Reference;
using Tax.Calculator.Domain.Entities.Transactional;

namespace Tax.Calculator.Data.EntityConfiguration
{
    public class TaxCalculationConfiguration : IEntityTypeConfiguration<TaxCalculation>
    {
        public void Configure(EntityTypeBuilder<TaxCalculation> builder)
        {
            builder.ToTable("TM_TXC_Tax_Calculation");
            builder.HasKey(t => t.Code).HasName("txc_code");
            builder.Property(p => p.Code).ValueGeneratedOnAdd();

            builder.Property(p => p.Level)
                .IsRequired()
                .HasColumnName("txc_level")
                .HasColumnType("int");

            builder.Property(p => p.MaximumAmount)
                .HasColumnName("txc_max_value")
                .HasColumnType("decimal(5,2)");

            builder.Property(p => p.MinimumAmount)
                .IsRequired()
                .HasColumnName("txc_min_amount")
                .HasColumnType("decimal(5,2)");

            builder.HasOne(f => f.TaxCalculationStrategy)
                .WithMany(p => p.TaxCalculation)
                .HasForeignKey(fk => fk.StrategyCode);

            builder.HasOne(f => f.TaxCalculationType)
                .WithMany(p => p.TaxCalculations)
                .HasForeignKey(fk => fk.TypeCode);

            builder.HasOne(f => f.TaxValue)
                .WithMany(p => p.TaxCalculations)
                .HasForeignKey(fk => fk.TaxValue);
                
        }
    }
}
