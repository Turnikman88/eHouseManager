using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHouseManager.Data.Migrations
{
    public partial class seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserTypeCD",
                schema: "18118025",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 46, DateTimeKind.Utc).AddTicks(6058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 302, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 47, DateTimeKind.Utc).AddTicks(993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 303, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 45, DateTimeKind.Utc).AddTicks(8248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 301, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 42, DateTimeKind.Utc).AddTicks(1019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 297, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 40, DateTimeKind.Utc).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 296, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 33, DateTimeKind.Utc).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 288, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "Apartments",
                columns: new[] { "Id", "Address", "ApartmentNumber", "AreTaxesPaid", "Area", "InhabitantsCount", "MyProperty", "Owner", "UcnNumber" },
                values: new object[,]
                {
                    { 1, "бул. Васил Левски, 25", "1", true, 100.25m, 4, null, "Петрови", 0 },
                    { 2, "бул. Васил Левски, 25", "2", false, 60.5m, 1, null, "Иванова", 0 },
                    { 3, "бул. Васил Левски, 25", "2A", false, 80.15m, 2, null, "Колеви", 0 },
                    { 4, "бул. Васил Левски, 25", "3", true, 100.25m, 1, null, "Динев", 0 },
                    { 5, "бул. Васил Левски, 25", "4", true, 100.25m, 3, null, "Георгиеви", 0 },
                    { 6, "бул. Васил Левски, 25", "5", false, 80.15m, 4, null, "Петров", 0 },
                    { 7, "бул. Васил Левски, 25", "6", false, 60.5m, 2, null, "Йорданови", 0 }
                });

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "Events",
                columns: new[] { "Id", "EventDateTime", "ModifiedOn18118025", "Status", "Title", "UcnNumber" },
                values: new object[,]
                {
                    { 17, new DateTime(2022, 6, 28, 23, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Спешна ремонтна дейност", 0 },
                    { 16, new DateTime(2022, 6, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Специализирана ремонтна дейност", 0 },
                    { 15, new DateTime(2022, 6, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Почистване на междублоковите пространства", 0 },
                    { 14, new DateTime(2022, 6, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Друго", 0 },
                    { 13, new DateTime(2022, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Събиране на месечни вноски", 0 },
                    { 12, new DateTime(2022, 5, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Среща с технически служител", 0 },
                    { 11, new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Технически преглед на общи части в ЕС", 0 },
                    { 10, new DateTime(2022, 5, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Събиране на месечни вноски", 0 },
                    { 6, new DateTime(2022, 3, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "отложено", "Общо събрание", 0 },
                    { 8, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Събиране на месечни вноски", 0 },
                    { 7, new DateTime(2022, 3, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Общо събрание", 0 },
                    { 5, new DateTime(2022, 3, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "отложено", "Общо събрание", 0 },
                    { 4, new DateTime(2022, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Технически преглед на общи части в ЕС", 0 },
                    { 3, new DateTime(2022, 3, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Събиране на месечни вноски", 0 },
                    { 2, new DateTime(2022, 2, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Друго", 0 },
                    { 1, new DateTime(2022, 2, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Среща с технически служител", 0 },
                    { 9, new DateTime(2022, 4, 15, 12, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "състояло се", "Специализирана ремонтна дейност", 0 }
                });

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "Password", "Phone", "Role", "UcnNumber" },
                values: new object[,]
                {
                    { 1, "radostina_991@abv.bg", "Радостина", false, "Накева", "radostina99", null, "Admin", 0 },
                    { 2, "petrov@abv.bg", "Иван", false, "Петров", "petrov99", null, "User", 0 }
                });

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "TaxPayments",
                columns: new[] { "Id", "Amount", "ApartmentId", "DueAmount", "Month", "PaidAmount", "PaidOn", "Year" },
                values: new object[] { 1, 50.00m, 1, 0.00m, 5, 50.00m, new DateTime(2022, 6, 1, 19, 5, 0, 0, DateTimeKind.Unspecified), 2022 });

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                columns: new[] { "Id", "ApartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 1, 2 }
                });

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "UserEventAccesses",
                columns: new[] { "Id", "EventId", "UserId" },
                values: new object[,]
                {
                    { 12, 12, 1 },
                    { 13, 13, 1 },
                    { 17, 17, 1 },
                    { 15, 15, 1 },
                    { 16, 16, 1 },
                    { 11, 11, 1 },
                    { 14, 14, 1 },
                    { 10, 10, 1 },
                    { 6, 6, 1 },
                    { 8, 8, 1 },
                    { 7, 7, 1 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 9, 9, 1 },
                    { 18, 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "TaxPayments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserApartmentAccesses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "UserEventAccesses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Events",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 302, DateTimeKind.Utc).AddTicks(4718),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 46, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.AddColumn<string>(
                name: "UserTypeCD",
                schema: "18118025",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 303, DateTimeKind.Utc).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 47, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 301, DateTimeKind.Utc).AddTicks(6360),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 45, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 297, DateTimeKind.Utc).AddTicks(6321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 42, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 296, DateTimeKind.Utc).AddTicks(817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 40, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 16, 29, 47, 288, DateTimeKind.Utc).AddTicks(9875),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 33, DateTimeKind.Utc).AddTicks(7057));
        }
    }
}
