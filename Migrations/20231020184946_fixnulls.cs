using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spades.Migrations
{
    /// <inheritdoc />
    public partial class fixnulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrickElemenents_Players_PlayerId",
                table: "TrickElemenents");

            migrationBuilder.DropIndex(
                name: "IX_TrickElemenents_PlayerId",
                table: "TrickElemenents");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "TrickElemenents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartStamp",
                table: "Hands",
                type: "datetime",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartStamp",
                table: "Games",
                type: "datetime",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "TrickElemenents",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartStamp",
                table: "Hands",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartStamp",
                table: "Games",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.CreateIndex(
                name: "IX_TrickElemenents_PlayerId",
                table: "TrickElemenents",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrickElemenents_Players_PlayerId",
                table: "TrickElemenents",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
