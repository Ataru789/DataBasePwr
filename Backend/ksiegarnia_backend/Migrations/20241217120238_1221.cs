using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ksiegarnia_backend.Migrations
{
    /// <inheritdoc />
    public partial class _1221 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_BookId",
                table: "ShoppingCarts",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Books_BookId",
                table: "ShoppingCarts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Books_BookId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_BookId",
                table: "ShoppingCarts");
        }
    }
}
