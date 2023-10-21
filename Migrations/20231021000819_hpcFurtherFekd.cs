using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class hpcFurtherFekd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandPlayerCards_Games_CardId",
                table: "HandPlayerCards");

            migrationBuilder.AddForeignKey(
                name: "FK_HandPlayerCards_Cards_CardId",
                table: "HandPlayerCards",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandPlayerCards_Cards_CardId",
                table: "HandPlayerCards");

            migrationBuilder.AddForeignKey(
                name: "FK_HandPlayerCards_Games_CardId",
                table: "HandPlayerCards",
                column: "CardId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
