using System;
using Microsoft.EntityFrameworkCore;
using Tax.Calculator.Data.EntityConfiguration;
using Tax.Calculator.Domain.Entities.Reference;
using Tax.Calculator.Domain.Entities.Transactional;
using Tax.Calculator.Domain.Reference.Entities;

namespace Tax.Calculator.Data
{
    public class TaxCalculatorContext : DbContext
    {
        public TaxCalculatorContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaxCalculationStrategyConfiguration());
            modelBuilder.ApplyConfiguration(new TaxCalculationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaxTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaxValueConfiguration());
            modelBuilder.ApplyConfiguration(new UserIncomeConfiguration());
        }

        DbSet<PostalCodeTax> PostalCodeTaxes { get; set; }
        DbSet<UserIncomeTax> UserIncomeTaxes { get; set; }
        DbSet<TaxCalculationType> TaxCalculationTypes { get; set; }
        DbSet<TaxValue> TaxValues { get; set; }
        DbSet<TaxCalculation> TaxCalculations { get; set; }
        DbSet<TaxCalculationStrategy> TaxCalculationStrategies { get; set; }
    } 
}
