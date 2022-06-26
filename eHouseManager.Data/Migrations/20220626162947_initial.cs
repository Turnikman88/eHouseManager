using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHouseManager.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "18118025");

            migrationBuilder.CreateTable(
                name: "Apartments",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 288, DateTimeKind.Utc).AddTicks(9875)),
                    ApartmentNumber = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    InhabitantsCount = table.Column<int>(nullable: false),
                    Area = table.Column<decimal>(nullable: false),
                    AreTaxesPaid = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    UcnNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UcnNumber = table.Column<int>(nullable: false),
                    EventDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "log_18118025",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(nullable: true),
                    OperationType = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 296, DateTimeKind.Utc).AddTicks(817))
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 302, DateTimeKind.Utc).AddTicks(4718)),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserTypeCD = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UcnNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayments",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 297, DateTimeKind.Utc).AddTicks(6321)),
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
                        principalSchema: "18118025",
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserApartmentAccesses",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 301, DateTimeKind.Utc).AddTicks(6360)),
                    UserId = table.Column<int>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApartmentAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalSchema: "18118025",
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserApartmentAccesses_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "18118025",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEventAccesses",
                schema: "18118025",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedOn18118025 = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 303, DateTimeKind.Utc).AddTicks(2754)),
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventAccesses_Events_EventId",
                        column: x => x.EventId,
                        principalSchema: "18118025",
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventAccesses_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "18118025",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentNumber",
                schema: "18118025",
                table: "Apartments",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_Id",
                schema: "18118025",
                table: "Apartments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_ApartmentId",
                schema: "18118025",
                table: "TaxPayments",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_Id",
                schema: "18118025",
                table: "TaxPayments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_Year",
                schema: "18118025",
                table: "TaxPayments",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_UserApartmentAccesses_ApartmentId",
                schema: "18118025",
                table: "UserApartmentAccesses",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserApartmentAccesses_UserId",
                schema: "18118025",
                table: "UserApartmentAccesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventAccesses_EventId",
                schema: "18118025",
                table: "UserEventAccesses",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventAccesses_UserId",
                schema: "18118025",
                table: "UserEventAccesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                schema: "18118025",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "log_18118025",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "TaxPayments",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "UserApartmentAccesses",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "UserEventAccesses",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "Apartments",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "Events",
                schema: "18118025");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "18118025");
        }
    }
}
