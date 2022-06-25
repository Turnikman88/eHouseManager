using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DataConfigurations
{
    class TaxTypeConfig : IEntityTypeConfiguration<TaxType>
    {
        public void Configure(EntityTypeBuilder<TaxType> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.ModifiedOn).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
