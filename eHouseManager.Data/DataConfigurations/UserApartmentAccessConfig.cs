using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DataConfigurations
{
    class UserApartmentAccessConfig : IEntityTypeConfiguration<UserApartmentAccess>
    {
        public void Configure(EntityTypeBuilder<UserApartmentAccess> builder)
        {
            builder.Property(x => x.ModifiedOn).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
