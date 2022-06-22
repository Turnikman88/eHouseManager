using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DataConfigurations
{
    class ApartmentConfig : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasIndex(x => x.ApartmentID);
            builder.HasIndex(x => x.ApartmentNumber);
        }
    }
}
