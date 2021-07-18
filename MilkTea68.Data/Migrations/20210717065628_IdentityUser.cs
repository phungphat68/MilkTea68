using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilkTea68.Data.Migrations
{
    public partial class IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"), "ba832319-65b9-40d3-9300-ad107628a7fa", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"), new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6"), 0, "cbfe9ec9-9959-400a-8d94-7f2ab7f3834a", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "phatph297@gmail.com", true, "Phat", "Phung", false, null, "phaph297@gmail.com", "admin", "AQAAAAEAACcQAAAAEPvhWwX9k8J6BnHhJnTcp7LPtIfxEpt5Ja9qUCVZVtC22bE+Q4jCIYGa2x/cP10J8w==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 13, 56, 27, 392, DateTimeKind.Local).AddTicks(9337));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e29504d2-0f8c-46cd-abf9-ca41f26636ce"), new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("00776e42-9409-4d12-84b4-6a3d7ba170a6"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 13, 36, 28, 667, DateTimeKind.Local).AddTicks(5837));
        }
    }
}
