using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Nirvana", "Grunge", "The man who sold the word" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Nirvana", "Grunge", "About a girl" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Nirvana", "Grunge", "you know you are right" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Foo Figthers", "Rock Alternativo", "Everlong" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Foo Figthers", "Rock Alternativo", "Best of you" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Foo Figthers", "Rock Alternativo", "Pretender" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Asap Rocky", "Hip hop", "Peso" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Asap Rocky", "Hip hop", "PMW" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Asap Rocky", "Hip hop", "lVL" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Juice world", "Hip hop", "Bandid" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Luís Freitas", "813635582", "M" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Andreia Gomes", "854613462", "F" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Cristina Sousa", "265368715", "F" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Sónia Rosa", "835623190", "F" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "António Santos", "751512205", "M" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Gustavo Alves", "728663835", "M" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Rosa Vieira", "644388118", "F" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Daniel Dias", "262618487", "M" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Tânia Gomes", "842615197", "F" });

            migrationBuilder.UpdateData(
                table: "Faixas",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Autor", "Genero", "Titulo" },
                values: new object[] { "Andreia Correia", "635139506", "F" });
        }
    }
}
