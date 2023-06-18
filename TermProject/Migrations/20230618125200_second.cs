using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TermProject.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991780d4-cb6f-4bb2-81fb-58324c0f26e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f5faeb-74f0-41a9-bb6b-0b99f4550463");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c5877e9-1dde-4528-be34-6f2ec1db7362", "936228a7-210b-4846-a28c-15cbafd73332", "admin", "ADMIN" },
                    { "a77b13da-c990-4532-b398-ddea4f0e1768", "7bd74566-a1c6-47d2-aa8d-7d1e4718c9f0", "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5877e9-1dde-4528-be34-6f2ec1db7362");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a77b13da-c990-4532-b398-ddea4f0e1768");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "991780d4-cb6f-4bb2-81fb-58324c0f26e1", "560d7bcb-c795-404f-a402-f472e2222ed3", "user", "USER" },
                    { "d2f5faeb-74f0-41a9-bb6b-0b99f4550463", "2be06a5f-d589-43fa-9978-feded06bc3ed", "admin", "ADMIN" }
                });
        }
    }
}
