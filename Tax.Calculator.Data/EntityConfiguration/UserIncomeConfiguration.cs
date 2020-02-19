using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Calculator.Domain.Entities.Transactional;

namespace Tax.Calculator.Data.EntityConfiguration
{
    public class UserIncomeConfiguration : IEntityTypeConfiguration<UserIncomeTax>
    {
        public UserIncomeConfiguration()
        {
        }

        

        public void Configure(EntityTypeBuilder<UserIncomeTax> builder)
        {
            builder.ToTable("TM_UIT_User_Income_Tax");
            builder.HasKey(o => o.Code).HasName("uit_code");
            builder.Property(p => p.Code).ValueGeneratedOnAdd();

            builder.Property(p => p.Date)
                .IsRequired()
                .HasColumnName("uit_date")
                .HasColumnType("DateTime")
                .HasDefaultValueSql("GetDate()");

            builder.Property(p => p.AnnualIncome)
                .IsRequired()
                .HasColumnName("uit_annual_come");

            builder.Property(p => p.IncomeTax)
                .IsRequired()
                .HasColumnName("uit_income_tax")
                .HasColumnType("decimal(5,2)");

            builder.Property(p => p.PostalCodeInput)
                .IsRequired()
                .HasColumnName("uit_postal_code")
                .HasColumnType("varchar(10)")

        }
    }
}
