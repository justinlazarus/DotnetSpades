using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class trickelementchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrickElemenents_Cards_CardId",
                table: "TrickElemenents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrickElemenents_Tricks_TrickId",
                table: "TrickElemenents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrickElemenents",
                table: "TrickElemenents");

            migrationBuilder.RenameTable(
                name: "TrickElemenents",
                newName: "TrickElements");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "TrickElements",
                newName: "HandPlayerCardId");

            migrationBuilder.RenameIndex(
                name: "IX_TrickElemenents_TrickId",
                table: "TrickElements",
                newName: "IX_TrickElements_TrickId");

            migrationBuilder.RenameIndex(
                name: "IX_TrickElemenents_CardId",
                table: "TrickElements",
                newName: "IX_TrickElements_HandPlayerCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrickElements",
                table: "TrickElements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElements_Cards_HandPlayerCardId",
                table: "TrickElements",
                column: "HandPlayerCardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElements_Tricks_TrickId",
                table: "TrickElements",
                column: "TrickId",
                principalTable: "Tricks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrickElements_Cards_HandPlayerCardId",
                table: "TrickElements");

            migrationBuilder.DropForeignKey(
                name: "FK_TrickElements_Tricks_TrickId",
                table: "TrickElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrickElements",
                table: "TrickElements");

            migrationBuilder.RenameTable(
                name: "TrickElements",
                newName: "TrickElemenents");

            migrationBuilder.RenameColumn(
                name: "HandPlayerCardId",
                table: "TrickElemenents",
                newName: "CardId");

            migrationBuilder.RenameIndex(
                name: "IX_TrickElements_TrickId",
                table: "TrickElemenents",
                newName: "IX_TrickElemenents_TrickId");

            migrationBuilder.RenameIndex(
                name: "IX_TrickElements_HandPlayerCardId",
                table: "TrickElemenents",
                newName: "IX_TrickElemenents_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrickElemenents",
                table: "TrickElemenents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElemenents_Cards_CardId",
                table: "TrickElemenents",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElemenents_Tricks_TrickId",
                table: "TrickElemenents",
                column: "TrickId",
                principalTable: "Tricks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
