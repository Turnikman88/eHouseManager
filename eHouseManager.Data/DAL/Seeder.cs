using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Data.DAL
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder mb)
        {
            var apartments = new List<Apartment>()
            {
                new Apartment()
                {
                    ApartmentID = 1
                }
            };

            mb.Entity<Apartment>().HasData(apartments);
        }
    }
}
