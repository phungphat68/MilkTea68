using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilkTea68.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d1cc2963-7929-421e-b3fa-0332e34b3e3a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f720a5d-1f6f-48ad-878b-6a0e281e80af", "AQAAAAEAACcQAAAAEMgqlz58cqxStObBg6KgdVnhJYEtpJ7S6tAAVsm383af2bdzPVRX+zwhEseSnquH3g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 20, 11, 26, 10, 396, DateTimeKind.Local).AddTicks(1692));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fc52586a-4691-47f0-a83b-8912f2157e80");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4552ec6e-d37c-4df2-aeb3-68c38b75ddfb", "AQAAAAEAACcQAAAAENgOBY3SiWzh+fP7BQTujwK4ZMcpPJSlXWrw0gvu0Ox0UOTXntQOiO+stcmsIT/prg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 19, 12, 28, 24, 612, DateTimeKind.Local).AddTicks(8180));
        }
    }
}
