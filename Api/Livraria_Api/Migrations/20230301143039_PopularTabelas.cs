using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Livraria_Api.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Nome" },
                values: new object[,]
                {
                    { 1, "JONATHAN SWIFT" },
                    { 2, "ROBERT LOUIS STEVERSON" },
                    { 3, "J. K. Rowling" }
                });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "AutorId", "DataLancamento", "Edicao", "Editora", "Nome" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1726, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "OXFORD BOOKWORMS", "Gulliver's Travels" },
                    { 2, 2, new DateTime(1986, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "RIchmond READERS", "Dr Jekyll & Mr Hyde" },
                    { 3, 3, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Editora Rocco", "Harry Potter and the Philosopher's Stone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 3);
        }
    }
}
