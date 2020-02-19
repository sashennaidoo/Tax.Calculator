using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tax.Calculator.Domain.Entities.Reference;

namespace Tax.Calculator.Data.EntityConfiguration
{
    public class TaxTypeConfiguration : IEntityTypeConfiguration<TaxType>
    {
        public TaxTypeConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<TaxType> builder)
        {
            builder.ToTable("TR_TXT_Tax_Type");

            builder.HasKey(o => o.Code).HasName("txt_code");
            builder.Property(p => p.Code).ValueGeneratedOnAdd();

            builder.HasMany(e => e.PostalCodes);
            
            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("txt_name")
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("txt_description")
                .HasColumnType("varchar(100)");

        }
    }
}
