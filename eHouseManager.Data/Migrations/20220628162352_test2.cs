using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHouseManager.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 508, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 509, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 360, DateTimeKind.Utc).AddTicks(2715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 507, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 356, DateTimeKind.Utc).AddTicks(5735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 504, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 355, DateTimeKind.Utc).AddTicks(1840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 502, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 348, DateTimeKind.Utc).AddTicks(5496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 496, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UcnNumber",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UcnNumber",
                value: 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 508, DateTimeKind.Utc).AddTicks(5292),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserEventAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 509, DateTimeKind.Utc).AddTicks(61),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 361, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "UserApartmentAccesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 507, DateTimeKind.Utc).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 360, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "TaxPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 504, DateTimeKind.Utc).AddTicks(1005),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 356, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                schema: "18118025",
                table: "log_18118025",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 502, DateTimeKind.Utc).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 355, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn18118025",
                schema: "18118025",
                table: "Apartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 16, 18, 26, 496, DateTimeKind.Utc).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 6, 28, 16, 23, 51, 348, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UcnNumber",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "18118025",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UcnNumber",
                value: 22);
        }
    }
}
