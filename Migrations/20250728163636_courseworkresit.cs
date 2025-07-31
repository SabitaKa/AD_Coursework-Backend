using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AD_Coursework.Migrations
{
    /// <inheritdoc />
    public partial class courseworkresit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b92c49d3-2503-4c04-abdf-205040d3ca23"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be2ebb32-a092-4c1e-a764-3adffd28d83f"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"),
                column: "ConcurrencyStamp",
                value: "f3e56c9e-0f53-43ff-897d-92c255b13e11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"),
                column: "ConcurrencyStamp",
                value: "00e5043c-a3b2-4379-951c-53bcfba20fbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd98e7-3a5b-4275-b4bb-8c7ccda0d6b0"),
                column: "ConcurrencyStamp",
                value: "89eb06cf-3ac2-45c5-98ec-2dec2891ce07");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsEligibleForLoyaltyDiscount", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiry", "RegistrationDate", "RoleId", "SecurityStamp", "TotalOrdersCompleted", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6b0ad6b7-a2d5-473d-acf5-1269a35c1bff"), 0, "Kathmandu, Nepal", "cc25fafb-4960-46e1-8dba-acbb0a94aff1", "admin@bookstore.com", true, "System Administrator", false, true, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE", "AQAAAAIAAYagAAAAEMClD7HGns3R6ieHVis+9gQAT+JTt6OOMwYzXkgdlPloTS+u8cFeqyrC74c7lzujow==", "1234567890", true, null, null, new DateTime(2025, 7, 28, 16, 36, 35, 383, DateTimeKind.Utc).AddTicks(3180), new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"), "a6187983-71db-4baa-9488-26d0ff12b6da", 0, false, "admin@bookstore" },
                    { new Guid("e6e6508f-6a83-4352-a39c-dfc42fb333c6"), 0, "Kathmandu, Nepal", "7d6e0b67-7b6d-453b-a27b-6db8ac135122", "staff@bookstore.com", true, "Bookstore Staff", false, true, null, "STAFF@BOOKSTORE.COM", "STAFF@BOOKSTORE", "AQAAAAIAAYagAAAAEMIJjPXv+01GN6KrBKrHe+f3qb0lRyGSrJ0gKOxgfw5NO4gs2vLlyXVsYmBSl4x3eg==", "0987654321", true, null, null, new DateTime(2025, 7, 28, 16, 36, 35, 438, DateTimeKind.Utc).AddTicks(9335), new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"), "33c75077-b4d6-4e40-8955-b9852f313138", 0, false, "staff@bookstore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b0ad6b7-a2d5-473d-acf5-1269a35c1bff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6e6508f-6a83-4352-a39c-dfc42fb333c6"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"),
                column: "ConcurrencyStamp",
                value: "c72125e3-8803-453d-8f5e-f01d42b2c25a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"),
                column: "ConcurrencyStamp",
                value: "0908aadd-2271-40eb-bf04-8d368308b145");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd98e7-3a5b-4275-b4bb-8c7ccda0d6b0"),
                column: "ConcurrencyStamp",
                value: "67083f48-3018-4899-840c-36a1d8432d1a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsEligibleForLoyaltyDiscount", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiry", "RegistrationDate", "RoleId", "SecurityStamp", "TotalOrdersCompleted", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b92c49d3-2503-4c04-abdf-205040d3ca23"), 0, "Kathmandu, Nepal", "6528a40a-4810-4e11-a6ef-7f640ca7d932", "admin@bookstore.com", true, "System Administrator", false, true, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE", "AQAAAAIAAYagAAAAEKD20aReiS8+8JgB2AQQ4i+zNmqLfziQ+4QZsOCqn2z/XpgnnVLW5OOdtdZpL5Q+QA==", "1234567890", true, null, null, new DateTime(2025, 5, 19, 13, 26, 14, 537, DateTimeKind.Utc).AddTicks(9269), new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"), "fd4ec7d4-2e0e-41b4-8884-f3ac4f012997", 0, false, "admin@bookstore" },
                    { new Guid("be2ebb32-a092-4c1e-a764-3adffd28d83f"), 0, "Kathmandu, Nepal", "5a8ae987-e059-4551-a6c5-f658129b6b4e", "staff@bookstore.com", true, "Bookstore Staff", false, true, null, "STAFF@BOOKSTORE.COM", "STAFF@BOOKSTORE", "AQAAAAIAAYagAAAAEJ/JzjJU88e5luNOpRIQuN/SgjpfTjvruHWUsojhsFkQFGCa98QIJ4zblHx9V/dTIQ==", "0987654321", true, null, null, new DateTime(2025, 5, 19, 13, 26, 14, 578, DateTimeKind.Utc).AddTicks(8241), new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"), "4b20b985-cba7-46d5-b81e-f6992fa76847", 0, false, "staff@bookstore" }
                });
        }
    }
}
