using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_Artistas_ArtistaID",
                table: "Albuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas");

            migrationBuilder.RenameTable(
                name: "Artistas",
                newName: "Artista");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artista",
                table: "Artista",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_Artista_ArtistaID",
                table: "Albuns",
                column: "ArtistaID",
                principalTable: "Artista",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_Artista_ArtistaID",
                table: "Albuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artista",
                table: "Artista");

            migrationBuilder.RenameTable(
                name: "Artista",
                newName: "Artistas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_Artistas_ArtistaID",
                table: "Albuns",
                column: "ArtistaID",
                principalTable: "Artistas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
