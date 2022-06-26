using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DataConfigurations
{
    class TaxPaymentConfig : IEntityTypeConfiguration<TaxPayment>
    {
        public void Configure(EntityTypeBuilder<TaxPayment> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.ModifiedOn).HasDefaultValue(DateTime.UtcNow);
            builder.HasIndex(x => x.Year);
            builder.HasOne(x => x.Apartment)
                .WithMany(x => x.TaxPayments)
                .HasForeignKey(x => x.ApartmentId);
        }
    }
}
