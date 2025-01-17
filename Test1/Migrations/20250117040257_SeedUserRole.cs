using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "97b3ca52-504c-4e4d-b843-f09f7cb71d08", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGOGPUqqgBTARdscUW1kB/fFDXVZSuzOIThtYSNegyeiDtdkHr48lhwPvtp4uzjI7w==", null, false, "007a5a28-733d-49a3-be91-5532626a0706", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(676), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(688), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(906), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1016), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1018), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1020), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1022), new DateTime(2025, 1, 17, 12, 2, 56, 913, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(106), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(351), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(354), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(462), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(466), new DateTime(2025, 1, 17, 10, 56, 27, 698, DateTimeKind.Local).AddTicks(467) });
        }
    }
}
