using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
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
                    table.PrimaryKey("PK_Artistas", x => x.ID);
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
                    FaixasFK = table.Column<int>(nullable: false),
                    ArtistaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albuns_Artistas_ArtistaID",
                        column: x => x.ArtistaID,
                        principalTable: "Artistas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albuns_Faixas_FaixasFK",
                        column: x => x.FaixasFK,
                        principalTable: "Faixas",
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
                table: "Artistas",
                columns: new[] { "ID", "FicheiroImg", "Nome", "Sexo" },
                values: new object[,]
                {
                    { 1, "dsfhshdfs", "Nirvana", "M" },
                    { 2, "dsfhshdfs", "Foo Figthers", "M" },
                    { 3, "dsfhshdfs", "Asap Rocky", "M" },
                    { 4, "dsfhshdfs", "Juice wrld", "M" }
                });

            migrationBuilder.InsertData(
                table: "Faixas",
                columns: new[] { "ID", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, "dsfhshdfs", "Grunge", "The man who sold the word" },
                    { 2, "dsfhshdfs", "Grunge", "About a girl" },
                    { 3, "dsfhshdfs", "Grunge", "come as you are" },
                    { 4, "dsfhshdfs", "Rock Alternativo", "Everlong" },
                    { 5, "dsfhshdfs", "Rock Alternativo", "Best of you" },
                    { 6, "dsfhshdfs", "Rock Alternativo", "Pretender" },
                    { 7, "dsfhshdfs", "Hip hop", "Fukk Sleep" },
                    { 8, "dsfhshdfs", "Hip hop", "PMW" },
                    { 9, "dsfhshdfs", "Hip hop", "lVL" },
                    { 10, "dsfhshdfs", "Hip hop", "Wasted" }
                });

            migrationBuilder.InsertData(
                table: "Albuns",
                columns: new[] { "ID", "ArtistaID", "FaixasFK", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, null, 1, "dsfhshdfs", "Grunge", "MTV Unplugged" },
                    { 2, null, 2, "dsfhshdfs", "Grunge", "Bleach" },
                    { 3, null, 3, "dsfhshdfs", "Grunge", "Nevermind" },
                    { 4, null, 4, "dsfhshdfs", "Rock Alternativo ", "The color and the shape" },
                    { 5, null, 5, "dsfhshdfs", "Rock Alternativo ", " In Your Honor" },
                    { 6, null, 6, "dsfhshdfs", "Rock Alternativo ", "Foo Fighters Echoes, Silence, Patience & Grace" },
                    { 7, null, 7, "dsfhshdfs", "Hip hop", "Testing" },
                    { 8, null, 8, "dsfhshdfs", "Hip hop", "Long. Live. ASAP" },
                    { 9, null, 10, "dsfhshdfs", "Hip hop ", "goodbye & good riddance" }
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
                name: "IX_Albuns_ArtistaID",
                table: "Albuns",
                column: "ArtistaID");

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_FaixasFK",
                table: "Albuns",
                column: "FaixasFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumFaixas");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Faixas");
        }
    }
}
