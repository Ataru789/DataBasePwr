using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ksiegarnia_backend.Migrations
{
    /// <inheritdoc />
    public partial class wiek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Miastoo",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Miastoo",
                table: "Admins",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
