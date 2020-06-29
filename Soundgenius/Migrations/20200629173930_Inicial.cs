using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class Inicial : Migration
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

            migrationBuilder.InsertData(
                table: "Artista",
                columns: new[] { "ID", "FicheiroImg", "Nome", "Sexo" },
                values: new object[,]
                {
                    { 1, "Nirvana", "Nirvana", "M" },
                    { 2, "Foo Figthers", "Foo Figthers", "M" },
                    { 3, "Asap Rocky", "Asap Rocky", "M" },
                    { 4, "Juice wrld", "Juice wrld", "M" }
                });

            migrationBuilder.InsertData(
                table: "Faixas",
                columns: new[] { "ID", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, "MTV Unplugged", "Grunge", "The man who sold the word" },
                    { 2, "Bleach", "Grunge", "About a girl" },
                    { 3, "Nevermind", "Grunge", "come as you are" },
                    { 4, "The color and the shape", "Rock Alternativo", "Everlong" },
                    { 5, "In Your Honor", "Rock Alternativo", "Best of you" },
                    { 6, "Testing", "Rock Alternativo", "Pretender" },
                    { 7, "dsfhshdfs", "Hip hop", "Fukk Sleep" },
                    { 8, "Long. Live. ASAP", "Hip hop", "PMW" },
                    { 9, "Long. Live. ASAP", "Hip hop", "lVL" },
                    { 10, "goodbye & good riddance", "Hip hop", "Wasted" }
                });

            migrationBuilder.InsertData(
                table: "Albuns",
                columns: new[] { "ID", "ArtistaFK", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, "MTV Unplugged", "Grunge", "MTV Unplugged" },
                    { 2, 1, "Bleach", "Grunge", "Bleach" },
                    { 3, 1, "Nevermind", "Grunge", "Nevermind" },
                    { 4, 2, "The color and the shape", "Rock Alternativo ", "The color and the shape" },
                    { 5, 2, "In Your Honor", "Rock Alternativo ", " In Your Honor" },
                    { 6, 2, "Foo Fighters Echoes, Silence, Patience & Grace", "Rock Alternativo ", "Foo Fighters Echoes, Silence, Patience & Grace" },
                    { 7, 3, "Testing", "Hip hop", "Testing" },
                    { 8, 3, "Long. Live. ASAP", "Hip hop", "Long. Live. ASAP" },
                    { 9, 4, "goodbye & good riddance", "Hip hop ", "goodbye & good riddance" }
                });

            migrationBuilder.InsertData(
                table: "AlbumFaixas",
                columns: new[] { "ID", "AlbumFK", "FaixaFK" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 10, 7, 9 },
                    { 8, 8, 8 },
                    { 9, 9, 10 }
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
