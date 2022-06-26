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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 382, DateTimeKind.Utc).AddTicks(8379)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ApartmentNumber = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    InhabitantsCount = table.Column<int>(nullable: false),
                    Area = table.Column<decimal>(nullable: false),
                    ObligationId = table.Column<string>(nullable: true),
                    AreTaxesPaid = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EventDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obligations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 428, DateTimeKind.Utc).AddTicks(7628)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obligations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 471, DateTimeKind.Utc).AddTicks(8346)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    TaxCD = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Calculation = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 488, DateTimeKind.Utc).AddTicks(872)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserTypeCD = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 436, DateTimeKind.Utc).AddTicks(9389)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaidOn = table.Column<DateTime>(nullable: true),
                    PaidAmount = table.Column<decimal>(nullable: false),
                    DueAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxPayments_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentObligationAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 423, DateTimeKind.Utc).AddTicks(1128)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ObligationId = table.Column<int>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentObligationAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmentObligationAccesses_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentObligationAccesses_Obligations_ObligationId",
                        column: x => x.ObligationId,
                        principalTable: "Obligations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserApartmentAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 479, DateTimeKind.Utc).AddTicks(1015)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApartmentAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEventAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 10, 41, 24, 491, DateTimeKind.Utc).AddTicks(2574)),
                    ModifiedBy = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventAccesses_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventAccesses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentObligationAccesses_ApartmentId",
                table: "ApartmentObligationAccesses",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentObligationAccesses_ObligationId",
                table: "ApartmentObligationAccesses",
                column: "ObligationId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentNumber",
                table: "Apartments",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_Id",
                table: "Apartments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Obligations_Id",
                table: "Obligations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_ApartmentId",
                table: "TaxPayments",
                column: "ApartmentId");

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
                name: "IX_UserApartmentAccesses_ApartmentId",
                table: "UserApartmentAccesses",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserApartmentAccesses_UserId",
                table: "UserApartmentAccesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventAccesses_EventId",
                table: "UserEventAccesses",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventAccesses_UserId",
                table: "UserEventAccesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentObligationAccesses");

            migrationBuilder.DropTable(
                name: "TaxPayments");

            migrationBuilder.DropTable(
                name: "TaxTypes");

            migrationBuilder.DropTable(
                name: "UserApartmentAccesses");

            migrationBuilder.DropTable(
                name: "UserEventAccesses");

            migrationBuilder.DropTable(
                name: "Obligations");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
