using eHouseManager.Data.DAL;
using eHouseManager.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace eHouseManager.Data
{
    public class eHouseManagerDbContext : DbContext
    {
        public static string FAKN = "18118025";

        public eHouseManagerDbContext()
        {

        }

        public eHouseManagerDbContext(DbContextOptions<eHouseManagerDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<TaxPayment> TaxPayments { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Obligation> Obligations { get; set; }
        public virtual DbSet<UserApartmentAccess> UserApartmentAccesses { get; set; }
        public virtual DbSet<ApartmentObligationAccess> ApartmentObligationAccesses { get; set; }
        public virtual DbSet<UserEventAccess> UserEventAccesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(FAKN);
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
