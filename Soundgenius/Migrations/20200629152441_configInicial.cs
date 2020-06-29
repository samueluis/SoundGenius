using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class configInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 40, nullable: false),
                    Sexo = table.Column<string>(maxLength: 1, nullable: true),
                    FicheiroImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Faixas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    FicheiroImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faixas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Albuns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    FicheiroImg = table.Column<string>(nullable: true),
                    ArtistaFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albuns_Artista_ArtistaFK",
                        column: x => x.ArtistaFK,
                        principalTable: "Artista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlbumFaixas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumFK = table.Column<int>(nullable: false),
                    FaixaFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumFaixas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AlbumFaixas_Albuns_AlbumFK",
                        column: x => x.AlbumFK,
                        principalTable: "Albuns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumFaixas_Faixas_FaixaFK",
                        column: x => x.FaixaFK,
                        principalTable: "Faixas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumFaixas_AlbumFK",
                table: "AlbumFaixas",
                column: "AlbumFK");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumFaixas_FaixaFK",
                table: "AlbumFaixas",
                column: "FaixaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_ArtistaFK",
                table: "Albuns",
                column: "ArtistaFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumFaixas");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Faixas");

            migrationBuilder.DropTable(
                name: "Artista");
        }
    }
}
