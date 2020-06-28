using Microsoft.EntityFrameworkCore.Migrations;

namespace Soundgenius.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faixas",
                columns: new[] { "ID", "Autor", "FicheiroImg", "Genero", "Titulo" },
                values: new object[,]
                {
                    { 1, "Luís Freitas", "dsfhshdfs", "813635582", "M" },
                    { 2, "Andreia Gomes", "dsfhshdfs", "854613462", "F" },
                    { 3, "Cristina Sousa", "dsfhshdfs", "265368715", "F" },
                    { 4, "Sónia Rosa", "dsfhshdfs", "835623190", "F" },
                    { 5, "António Santos", "dsfhshdfs", "751512205", "M" },
                    { 6, "Gustavo Alves", "dsfhshdfs", "728663835", "M" },
                    { 7, "Rosa Vieira", "dsfhshdfs", "644388118", "F" },
                    { 8, "Daniel Dias", "dsfhshdfs", "262618487", "M" },
                    { 9, "Tânia Gomes", "dsfhshdfs", "842615197", "F" },
                    { 10, "Andreia Correia", "dsfhshdfs", "635139506", "F" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
