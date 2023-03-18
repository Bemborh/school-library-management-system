using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolLIbrary.Migrations
{
    /// <inheritdoc />
    public partial class latifatfirstDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b5426e-1f72-4e09-b68c-a68c2c16c8e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5346dab5-86b5-4c4f-a5ab-1554df16a730");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc978e3e-d2e8-4ed2-bcc0-f4a5e6dc3519");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2368dabf-899b-4755-9a67-a7fe74608667", null, "Student", "STUDENT" },
                    { "34d3be1d-8ed4-4eef-b7c7-6880c03dab7e", null, "Admin", "ADMIN" },
                    { "bb9a9c74-b991-4dc8-83ba-cd572e9a6524", null, "Lecturer", "LECTURER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2368dabf-899b-4755-9a67-a7fe74608667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34d3be1d-8ed4-4eef-b7c7-6880c03dab7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb9a9c74-b991-4dc8-83ba-cd572e9a6524");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30b5426e-1f72-4e09-b68c-a68c2c16c8e4", null, "Student", "STUDENT" },
                    { "5346dab5-86b5-4c4f-a5ab-1554df16a730", null, "Lecturer", "LECTURER" },
                    { "cc978e3e-d2e8-4ed2-bcc0-f4a5e6dc3519", null, "Admin", "ADMIN" }
                });
        }
    }
}
