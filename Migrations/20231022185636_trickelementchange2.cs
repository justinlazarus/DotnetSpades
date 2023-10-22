using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class trickelementchange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrickElements_Cards_HandPlayerCardId",
                table: "TrickElements");

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElements_HandPlayerCards_HandPlayerCardId",
                table: "TrickElements",
                column: "HandPlayerCardId",
                principalTable: "HandPlayerCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrickElements_HandPlayerCards_HandPlayerCardId",
                table: "TrickElements");

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElements_Cards_HandPlayerCardId",
                table: "TrickElements",
                column: "HandPlayerCardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
