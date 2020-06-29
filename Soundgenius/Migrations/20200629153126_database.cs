using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artista",
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
                columns: new[] { "ID", "ArtistaFK", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, "dsfhshdfs", "Grunge", "MTV Unplugged" },
                    { 2, 1, "dsfhshdfs", "Grunge", "Bleach" },
                    { 3, 1, "dsfhshdfs", "Grunge", "Nevermind" },
                    { 4, 2, "dsfhshdfs", "Rock Alternativo ", "The color and the shape" },
                    { 5, 2, "dsfhshdfs", "Rock Alternativo ", " In Your Honor" },
                    { 6, 2, "dsfhshdfs", "Rock Alternativo ", "Foo Fighters Echoes, Silence, Patience & Grace" },
                    { 7, 3, "dsfhshdfs", "Hip hop", "Testing" },
                    { 8, 3, "dsfhshdfs", "Hip hop", "Long. Live. ASAP" },
                    { 9, 4, "dsfhshdfs", "Hip hop ", "goodbye & good riddance" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AlbumFaixas",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albuns",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artista",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artista",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artista",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artista",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
