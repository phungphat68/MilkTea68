using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilkTea68.Data.Migrations
{
    public partial class IdentityUserupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"),
                column: "ConcurrencyStamp",
                value: "104d3526-4b59-4158-a159-466381e7d04c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00ab42b6-6339-4702-9cd2-fbdc85e54b9c", "AQAAAAEAACcQAAAAENq8xewjHYik9XLGpZ1cNEwa7Fh2Z2U7KqqZCW2pdL3gGCtTGJcNnNj3HS8XCyCpfQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 18, 13, 45, 4, 169, DateTimeKind.Local).AddTicks(7449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"),
                column: "ConcurrencyStamp",
                value: "ba832319-65b9-40d3-9300-ad107628a7fa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbfe9ec9-9959-400a-8d94-7f2ab7f3834a", "AQAAAAEAACcQAAAAEPvhWwX9k8J6BnHhJnTcp7LPtIfxEpt5Ja9qUCVZVtC22bE+Q4jCIYGa2x/cP10J8w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 13, 56, 27, 392, DateTimeKind.Local).AddTicks(9337));
        }
    }
}
