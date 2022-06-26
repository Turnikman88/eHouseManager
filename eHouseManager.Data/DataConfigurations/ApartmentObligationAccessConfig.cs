using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DataConfigurations
{
    class ApartmentObligationAccessConfig : IEntityTypeConfiguration<ApartmentObligationAccess>
    {
        public void Configure(EntityTypeBuilder<ApartmentObligationAccess> builder)
        {
            builder.Property(x => x.ModifiedOn).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
