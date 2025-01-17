using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(2793), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(2815), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3227), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3231), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3422), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3426), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3430), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3434), new DateTime(2025, 1, 17, 9, 31, 32, 272, DateTimeKind.Local).AddTicks(3436) });
        }
    }
}
