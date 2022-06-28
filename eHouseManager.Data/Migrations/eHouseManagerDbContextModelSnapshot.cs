﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eHouseManager.Data;

namespace eHouseManager.Data.Migrations
{
    [DbContext(typeof(eHouseManagerDbContext))]
    partial class eHouseManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("18118025")
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AreTaxesPaid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InhabitantsCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 348, DateTimeKind.Utc).AddTicks(5496));

                    b.Property<string>("MyProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcnNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentNumber");

                    b.HasIndex("Id");

                    b.ToTable("Apartments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "1",
                            AreTaxesPaid = true,
                            Area = 100.25m,
                            InhabitantsCount = 4,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Петрови",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 2,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "2",
                            AreTaxesPaid = false,
                            Area = 60.5m,
                            InhabitantsCount = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Иванова",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 3,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "2A",
                            AreTaxesPaid = false,
                            Area = 80.15m,
                            InhabitantsCount = 2,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Колеви",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 4,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "3",
                            AreTaxesPaid = true,
                            Area = 100.25m,
                            InhabitantsCount = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Динев",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 5,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "4",
                            AreTaxesPaid = true,
                            Area = 100.25m,
                            InhabitantsCount = 3,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Георгиеви",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 6,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "5",
                            AreTaxesPaid = false,
                            Area = 80.15m,
                            InhabitantsCount = 4,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Петров",
                            UcnNumber = 11
                        },
                        new
                        {
                            Id = 7,
                            Address = "бул. Васил Левски, 25",
                            ApartmentNumber = "6",
                            AreTaxesPaid = false,
                            Area = 60.5m,
                            InhabitantsCount = 2,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Owner = "Йорданови",
                            UcnNumber = 22
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcnNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventDateTime = new DateTime(2022, 2, 15, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Среща с технически служител",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 2,
                            EventDateTime = new DateTime(2022, 2, 24, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Друго",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 3,
                            EventDateTime = new DateTime(2022, 3, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Събиране на месечни вноски",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 4,
                            EventDateTime = new DateTime(2022, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Технически преглед на общи части в ЕС",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 5,
                            EventDateTime = new DateTime(2022, 3, 15, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "отложено",
                            Title = "Общо събрание",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 6,
                            EventDateTime = new DateTime(2022, 3, 16, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "отложено",
                            Title = "Общо събрание",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 7,
                            EventDateTime = new DateTime(2022, 3, 18, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Общо събрание",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 8,
                            EventDateTime = new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Събиране на месечни вноски",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 9,
                            EventDateTime = new DateTime(2022, 4, 15, 12, 20, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Специализирана ремонтна дейност",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 10,
                            EventDateTime = new DateTime(2022, 5, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Събиране на месечни вноски",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 11,
                            EventDateTime = new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Технически преглед на общи части в ЕС",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 12,
                            EventDateTime = new DateTime(2022, 5, 15, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Среща с технически служител",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 13,
                            EventDateTime = new DateTime(2022, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Събиране на месечни вноски",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 14,
                            EventDateTime = new DateTime(2022, 6, 12, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Друго",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 15,
                            EventDateTime = new DateTime(2022, 6, 18, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Почистване на междублоковите пространства",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 16,
                            EventDateTime = new DateTime(2022, 6, 25, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Специализирана ремонтна дейност",
                            UcnNumber = 0
                        },
                        new
                        {
                            Id = 17,
                            EventDateTime = new DateTime(2022, 6, 28, 23, 33, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "състояло се",
                            Title = "Спешна ремонтна дейност",
                            UcnNumber = 0
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.Log", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 355, DateTimeKind.Utc).AddTicks(1840));

                    b.Property<string>("OperationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("log_18118025");
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.TaxPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 356, DateTimeKind.Utc).AddTicks(5735));

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("PaidOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("Id");

                    b.HasIndex("Year");

                    b.ToTable("TaxPayments");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Amount = 50.00m,
                            ApartmentId = 1,
                            DueAmount = 0.00m,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Month = 5,
                            PaidAmount = 50.00m,
                            PaidOn = new DateTime(2022, 6, 1, 19, 5, 0, 0, DateTimeKind.Unspecified),
                            Year = 2022
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(598));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcnNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "radostina_991@abv.bg",
                            FirstName = "Радостина",
                            IsActive = true,
                            LastName = "Накева",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "radostina99",
                            Role = "Admin",
                            UcnNumber = 12
                        },
                        new
                        {
                            Id = 2,
                            Email = "petrov@abv.bg",
                            FirstName = "Иван",
                            IsActive = true,
                            LastName = "Петров",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "petrov99",
                            Role = "User",
                            UcnNumber = 11
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.UserApartmentAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 360, DateTimeKind.Utc).AddTicks(2715));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("UserApartmentAccesses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentId = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApartmentId = 2,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ApartmentId = 3,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            ApartmentId = 4,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            ApartmentId = 5,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            ApartmentId = 6,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            ApartmentId = 7,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            ApartmentId = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.UserEventAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModifiedOn18118025")
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(5449));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEventAccesses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventId = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            EventId = 2,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            EventId = 3,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            EventId = 4,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            EventId = 5,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            EventId = 6,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            EventId = 7,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            EventId = 8,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            EventId = 9,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            EventId = 10,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            EventId = 11,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            EventId = 12,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 13,
                            EventId = 13,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            EventId = 14,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 15,
                            EventId = 15,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            EventId = 16,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 17,
                            EventId = 17,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 18,
                            EventId = 1,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.TaxPayment", b =>
                {
                    b.HasOne("eHouseManager.Data.DatabaseModels.Apartment", "Apartment")
                        .WithMany("TaxPayments")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.UserApartmentAccess", b =>
                {
                    b.HasOne("eHouseManager.Data.DatabaseModels.Apartment", "Apartment")
                        .WithMany("UserApartmentAccesses")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eHouseManager.Data.DatabaseModels.User", "User")
                        .WithMany("UserApartmentAccesses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eHouseManager.Data.DatabaseModels.UserEventAccess", b =>
                {
                    b.HasOne("eHouseManager.Data.DatabaseModels.Event", "Event")
                        .WithMany("UserEventAccesses")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eHouseManager.Data.DatabaseModels.User", "User")
                        .WithMany("UserEventAccesses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
