using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilkTea68.Data.Migrations
{
    public partial class Changefilelentgthtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ae8641fe-de2c-46ae-8eb5-f39047acd27c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6f2abf4-672a-4f6a-b9bc-4142c96c092a", "AQAAAAEAACcQAAAAENqoItcPAsJZOYdIE/5L9ZInHLOxQ3hJkDePZRlVxkwN7+krlFbdj71OCmLLfZTs1w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 18, 21, 19, 6, 706, DateTimeKind.Local).AddTicks(869));
        }
    }
}
