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
                new Apartment() { Id = 1, ApartmentNumber="1", Owner="Петрови", Area=100.25M, InhabitantsCount=4, AreTaxesPaid=true, Address="бул. Васил Левски, 25", UcnNumber = 11 },
                new Apartment() { Id = 2, ApartmentNumber="2", Owner="Иванова", Area=60.5M, InhabitantsCount=1, AreTaxesPaid=false, Address="бул. Васил Левски, 25", UcnNumber = 11 },
                new Apartment() { Id = 3, ApartmentNumber="2A", Owner="Колеви", Area=80.15M, InhabitantsCount=2, AreTaxesPaid=false, Address="бул. Васил Левски, 25", UcnNumber = 11 },
                new Apartment() { Id = 4, ApartmentNumber="3", Owner="Динев", Area=100.25M, InhabitantsCount=1, AreTaxesPaid=true, Address="бул. Васил Левски, 25", UcnNumber = 11 },
                new Apartment() { Id = 5, ApartmentNumber="4", Owner="Георгиеви", Area=100.25M, InhabitantsCount=3, AreTaxesPaid=true, Address="бул. Васил Левски, 25", UcnNumber = 11 },
                new Apartment() { Id = 6, ApartmentNumber="5", Owner="Петров", Area=80.15M, InhabitantsCount=4, AreTaxesPaid=false, Address="бул. Васил Левски, 25", UcnNumber = 11},
                new Apartment() { Id = 7, ApartmentNumber="6", Owner="Йорданови", Area=60.5M, InhabitantsCount=2, AreTaxesPaid=false, Address="бул. Васил Левски, 25", UcnNumber = 22 }
            };

            var taxPayments = new List<TaxPayment>()
            {
                new TaxPayment() { Id = 3, Year=2022, Month=5, ApartmentId=1, Amount=50.00M, PaidAmount=50.00M, DueAmount=0.00M, PaidOn=new DateTime(2022, 6, 1, 19, 05, 00) }
            };

            var users = new List<User>()
            {
                new User() {Id = 1, FirstName = "Радостина", LastName = "Накева", Role="Admin", Email="radostina_991@abv.bg", Password="radostina99", IsActive = true, UcnNumber = 12 },
                new User() {Id = 2, FirstName = "Иван", LastName = "Петров", Role="User", Email="petrov@abv.bg", Password="petrov99" , IsActive = true, UcnNumber = 11}
            };

            var events = new List<Event>()
            {
                new Event() { Id = 1, Status="състояло се", Title = "Среща с технически служител", EventDateTime = new DateTime(2022, 2, 15, 18, 30, 00) },
                new Event() { Id = 2, Status="състояло се", Title = "Друго", EventDateTime = new DateTime(2022, 2, 24, 12, 30, 00) },
                new Event() { Id = 3, Status="състояло се", Title = "Събиране на месечни вноски", EventDateTime = new DateTime(2022, 3, 1, 18, 00, 00) },
                new Event() { Id = 4, Status="състояло се", Title = "Технически преглед на общи части в ЕС", EventDateTime = new DateTime(2022, 3, 7, 16, 30, 00) },
                new Event() { Id = 5, Status="отложено", Title = "Общо събрание", EventDateTime = new DateTime(2022, 3, 15, 18, 30, 00) },
                new Event() { Id = 6, Status="отложено", Title = "Общо събрание", EventDateTime = new DateTime(2022, 3, 16, 19, 00, 00) },
                new Event() { Id = 7, Status="състояло се", Title = "Общо събрание", EventDateTime = new DateTime(2022, 3, 18, 19, 30, 00) },
                new Event() { Id = 8, Status="състояло се", Title = "Събиране на месечни вноски", EventDateTime = new DateTime(2022, 4, 1, 18, 00, 00) },
                new Event() { Id = 9, Status="състояло се", Title = "Специализирана ремонтна дейност", EventDateTime = new DateTime(2022, 4, 15, 12, 20, 00) },
                new Event() { Id = 10, Status="състояло се", Title = "Събиране на месечни вноски", EventDateTime = new DateTime(2022, 5, 1, 18, 00, 00) },
                new Event() { Id = 11, Status="състояло се", Title = "Технически преглед на общи части в ЕС", EventDateTime = new DateTime(2022, 5, 7, 16, 30, 00) },
                new Event() { Id = 12, Status="състояло се", Title = "Среща с технически служител", EventDateTime = new DateTime(2022, 5, 15, 18, 30, 00) },
                new Event() { Id = 13, Status="състояло се", Title = "Събиране на месечни вноски", EventDateTime = new DateTime(2022, 6, 1, 18, 00, 00) },
                new Event() { Id = 14, Status="състояло се", Title = "Друго", EventDateTime = new DateTime(2022, 6, 12, 18, 30, 00) },
                new Event() { Id = 15, Status="състояло се", Title = "Почистване на междублоковите пространства", EventDateTime = new DateTime(2022, 6, 18, 10, 30, 00) },
                new Event() { Id = 16, Status="състояло се", Title = "Специализирана ремонтна дейност", EventDateTime = new DateTime(2022, 6, 25, 15, 30, 00) },
                new Event() { Id = 17, Status="състояло се", Title = "Спешна ремонтна дейност", EventDateTime = new DateTime(2022, 6, 28, 23, 33, 00) }
            };

            var userEventAccess = new List<UserEventAccess>()
            {
                new UserEventAccess() { Id = 1, UserId=1, EventId=1 },
                new UserEventAccess() { Id = 2, UserId=1, EventId=2 },
                new UserEventAccess() { Id = 3, UserId=1, EventId=3 },
                new UserEventAccess() { Id = 4, UserId=1, EventId=4 },
                new UserEventAccess() { Id = 5, UserId=1, EventId=5 },
                new UserEventAccess() { Id = 6, UserId=1, EventId=6 },
                new UserEventAccess() { Id = 7, UserId=1, EventId=7 },
                new UserEventAccess() { Id = 8, UserId=1, EventId=8 },
                new UserEventAccess() { Id = 9, UserId=1, EventId=9 },
                new UserEventAccess() { Id = 10, UserId=1, EventId=10 },
                new UserEventAccess() { Id = 11, UserId=1, EventId=11 },
                new UserEventAccess() { Id = 12, UserId=1, EventId=12 },
                new UserEventAccess() { Id = 13, UserId=1, EventId=13 },
                new UserEventAccess() { Id = 14, UserId=1, EventId=14 },
                new UserEventAccess() { Id = 15, UserId=1, EventId=15 },
                new UserEventAccess() { Id = 16, UserId=1, EventId=16 },
                new UserEventAccess() { Id = 17, UserId=1, EventId=17 },
                new UserEventAccess() { Id = 18, UserId=2, EventId=1 }

            };
            var userApartmentAccess = new List<UserApartmentAccess>()
            {
                new UserApartmentAccess() { Id = 1, UserId=1, ApartmentId=1 },
                new UserApartmentAccess() { Id = 2, UserId=1, ApartmentId=2 },
                new UserApartmentAccess() { Id = 3, UserId=1, ApartmentId=3 },
                new UserApartmentAccess() { Id = 4, UserId=1, ApartmentId=4 },
                new UserApartmentAccess() { Id = 5,UserId=1, ApartmentId=5 },
                new UserApartmentAccess() { Id = 6,UserId=1, ApartmentId=6 },
                new UserApartmentAccess() { Id = 7, UserId=1, ApartmentId=7 },
                new UserApartmentAccess() { Id = 8, UserId=2, ApartmentId=1 }
            };

            mb.Entity<Apartment>().HasData(apartments);
            mb.Entity<TaxPayment>().HasData(taxPayments);
            mb.Entity<User>().HasData(users);
            mb.Entity<Event>().HasData(events);
            mb.Entity<UserEventAccess>().HasData(userEventAccess);
            mb.Entity<UserApartmentAccess>().HasData(userApartmentAccess);
        }
    }
}
