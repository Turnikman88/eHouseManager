using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHouseManager.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentNumber = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Inhabitants = table.Column<int>(nullable: false),
                    Area = table.Column<decimal>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EventDateTime = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "TaxTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxCD = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Calculation = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserTypeCD = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    ApartmentID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaidOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<decimal>(nullable: false),
                    DueAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxPayments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserApartmentAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    ApartmentID = table.Column<int>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApartmentAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentID",
                table: "Apartments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentNumber",
                table: "Apartments",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_ApartmentID",
                table: "TaxPayments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_Id",
                table: "TaxPayments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_Year",
                table: "TaxPayments",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_TaxTypes_Id",
                table: "TaxTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserApartmentAccesses_ApartmentID",
                table: "UserApartmentAccesses",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UserApartmentAccesses_UserID",
                table: "UserApartmentAccesses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserID",
                table: "Users",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "TaxPayments");

            migrationBuilder.DropTable(
                name: "TaxTypes");

            migrationBuilder.DropTable(
                name: "UserApartmentAccesses");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
