using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Suit = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndStamp = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hands_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HandId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrickCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_Hands_HandId",
                        column: x => x.HandId,
                        principalTable: "Hands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bids_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tricks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HandId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndStamp = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tricks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tricks_Hands_HandId",
                        column: x => x.HandId,
                        principalTable: "Hands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrickElemenents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrickId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrickElemenents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrickElemenents_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrickElemenents_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrickElemenents_Tricks_TrickId",
                        column: x => x.TrickId,
                        principalTable: "Tricks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Suit", "Value" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 1, 4 },
                    { 4, 1, 5 },
                    { 5, 1, 6 },
                    { 6, 1, 7 },
                    { 7, 1, 8 },
                    { 8, 1, 9 },
                    { 9, 1, 10 },
                    { 10, 1, 11 },
                    { 11, 1, 12 },
                    { 12, 1, 13 },
                    { 13, 1, 14 },
                    { 14, 2, 2 },
                    { 15, 2, 3 },
                    { 16, 2, 4 },
                    { 17, 2, 5 },
                    { 18, 2, 6 },
                    { 19, 2, 7 },
                    { 20, 2, 8 },
                    { 21, 2, 9 },
                    { 22, 2, 10 },
                    { 23, 2, 11 },
                    { 24, 2, 12 },
                    { 25, 2, 13 },
                    { 26, 2, 14 },
                    { 27, 3, 2 },
                    { 28, 3, 3 },
                    { 29, 3, 4 },
                    { 30, 3, 5 },
                    { 31, 3, 6 },
                    { 32, 3, 7 },
                    { 33, 3, 8 },
                    { 34, 3, 9 },
                    { 35, 3, 10 },
                    { 36, 3, 11 },
                    { 37, 3, 12 },
                    { 38, 3, 13 },
                    { 39, 3, 14 },
                    { 40, 4, 2 },
                    { 41, 4, 3 },
                    { 42, 4, 4 },
                    { 43, 4, 5 },
                    { 44, 4, 6 },
                    { 45, 4, 7 },
                    { 46, 4, 8 },
                    { 47, 4, 9 },
                    { 48, 4, 10 },
                    { 49, 4, 11 },
                    { 50, 4, 12 },
                    { 51, 4, 13 },
                    { 52, 4, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_HandId",
                table: "Bids",
                column: "HandId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_PlayerId",
                table: "Bids",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Hands_GameId",
                table: "Hands",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_TrickElemenents_CardId",
                table: "TrickElemenents",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_TrickElemenents_PlayerId",
                table: "TrickElemenents",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrickElemenents_TrickId",
                table: "TrickElemenents",
                column: "TrickId");

            migrationBuilder.CreateIndex(
                name: "IX_Tricks_HandId",
                table: "Tricks",
                column: "HandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "TrickElemenents");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tricks");

            migrationBuilder.DropTable(
                name: "Hands");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
