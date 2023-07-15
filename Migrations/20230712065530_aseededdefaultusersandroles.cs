using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class aseededdefaultusersandroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0046D347-BEDF-4CB0-8B5A-62EC3E143C93", "2fe84c35-f50c-4b21-be24-166dc57e8f39", "User", "USER" },
                    { "F51BF010-9B16-425C-AB0A-3450E198C50E", "5a41c5e6-3a88-4c46-bd83-42c21f41921b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16AF55E1-EB88-4878-9607-90BB52BFA5E0", 0, "077d104d-c800-4974-9a69-74f8e0bfc5ad", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEI/xlF28J6L7YFRQ+IPK4o0QQZiHD8eIlmZQErg2sPC+KLNXYL5xUV3w9enDCqZxQw==", null, false, "141479ba-8cd5-4f61-8f7e-10eaefd41d74", false, "user@bookstore.com" },
                    { "3D437071-492A-4F12-B345-6E0B698631A6", 0, "11a29048-76ab-4390-b9be-cc8bfa8b98ce", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEDkpBBRnUGFYp0N/3KtQXwa5S9LOMGVAdvKAk1tFKMOjrbgfpPcGfdmgxwWYkqsk5g==", null, false, "e7d6cf53-3d55-4cda-9653-8518e064b694", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0046D347-BEDF-4CB0-8B5A-62EC3E143C93", "16AF55E1-EB88-4878-9607-90BB52BFA5E0" },
                    { "F51BF010-9B16-425C-AB0A-3450E198C50E", "3D437071-492A-4F12-B345-6E0B698631A6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0046D347-BEDF-4CB0-8B5A-62EC3E143C93", "16AF55E1-EB88-4878-9607-90BB52BFA5E0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F51BF010-9B16-425C-AB0A-3450E198C50E", "3D437071-492A-4F12-B345-6E0B698631A6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0046D347-BEDF-4CB0-8B5A-62EC3E143C93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F51BF010-9B16-425C-AB0A-3450E198C50E");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16AF55E1-EB88-4878-9607-90BB52BFA5E0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3D437071-492A-4F12-B345-6E0B698631A6");
        }
    }
}
