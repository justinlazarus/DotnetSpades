using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class hpcFekd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandPlayerCards_Games_HandId",
                table: "HandPlayerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_HandPlayerCards_Games_PlayerId",
                table: "HandPlayerCards");

            migrationBuilder.DropIndex(
                name: "IX_HandPlayerCards_HandId",
                table: "HandPlayerCards");

            migrationBuilder.DropColumn(
                name: "HandId",
                table: "HandPlayerCards");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "HandPlayerCards",
                newName: "HandPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_HandPlayerCards_PlayerId",
                table: "HandPlayerCards",
                newName: "IX_HandPlayerCards_HandPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HandPlayerCards_HandPlayers_HandPlayerId",
                table: "HandPlayerCards",
                column: "HandPlayerId",
                principalTable: "HandPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandPlayerCards_HandPlayers_HandPlayerId",
                table: "HandPlayerCards");

            migrationBuilder.RenameColumn(
                name: "HandPlayerId",
                table: "HandPlayerCards",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_HandPlayerCards_HandPlayerId",
                table: "HandPlayerCards",
                newName: "IX_HandPlayerCards_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "HandId",
                table: "HandPlayerCards",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HandPlayerCards_HandId",
                table: "HandPlayerCards",
                column: "HandId");

            migrationBuilder.AddForeignKey(
                name: "FK_HandPlayerCards_Games_HandId",
                table: "HandPlayerCards",
                column: "HandId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandPlayerCards_Games_PlayerId",
                table: "HandPlayerCards",
                column: "PlayerId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
