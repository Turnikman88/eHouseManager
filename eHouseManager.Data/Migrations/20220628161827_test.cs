using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHouseManager.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "TaxPayments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 508, DateTimeKind.Utc).AddTicks(5292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 46, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 509, DateTimeKind.Utc).AddTicks(61),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 47, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 507, DateTimeKind.Utc).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 45, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 504, DateTimeKind.Utc).AddTicks(1005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 42, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 502, DateTimeKind.Utc).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 40, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 496, DateTimeKind.Utc).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 33, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 1,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 3,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 4,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 5,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 6,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 7,
                column: "UcnNumber",
                value: 22);

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "TaxPayments",
                columns: new[] { "Id", "Amount", "ApartmentId", "DueAmount", "Month", "PaidAmount", "PaidOn", "Year" },
                values: new object[] { 3, 50.00m, 1, 0.00m, 5, 50.00m, new DateTime(2022, 6, 1, 19, 5, 0, 0, DateTimeKind.Unspecified), 2022 });

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "UcnNumber" },
                values: new object[] { true, 11 });

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "UcnNumber" },
                values: new object[] { true, 22 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "18118025",
                table: "TaxPayments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 46, DateTimeKind.Utc).AddTicks(6058),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 508, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 47, DateTimeKind.Utc).AddTicks(993),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 509, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 45, DateTimeKind.Utc).AddTicks(8248),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 507, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 42, DateTimeKind.Utc).AddTicks(1019),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 504, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 40, DateTimeKind.Utc).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 502, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 8, 14, 7, 33, DateTimeKind.Utc).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 496, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 1,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 3,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 4,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 5,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 6,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 7,
                column: "UcnNumber",
                value: 0);

            migrationBuilder.InsertData(
                schema: "18118025",
                table: "TaxPayments",
                columns: new[] { "Id", "Amount", "ApartmentId", "DueAmount", "Month", "PaidAmount", "PaidOn", "Year" },
                values: new object[] { 1, 50.00m, 1, 0.00m, 5, 50.00m, new DateTime(2022, 6, 1, 19, 5, 0, 0, DateTimeKind.Unspecified), 2022 });

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "UcnNumber" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "UcnNumber" },
                values: new object[] { false, 0 });
        }
    }
}
