using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_Api.Migrations
{
    /// <inheritdoc />
    public partial class PopularTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authoes",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "Jonathan Swift" },
                    { 2, "Robert Louis Steverson" },
                    { 3, "J. K. Rowling" },
                    { 4, "Jennifer Niven" },
                    { 5, "Stephen King" },
                    { 6, "Coolen Hover" },
                    { 7, "Charlie Donlea" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Edition", "Name", "Price", "PublishingCompany", "UrlWebImg", "YearLauch" },
                values: new object[,]
                {
                    { 1, 1, 1, "Gulliver's Travels", 59m, "Pearson English", "https://m.media-amazon.com/images/I/51W6w1PrkbL._SX384_BO1,204,203,200_.jpg", "1726" },
                    { 2, 2, 3, "Dr Jekyll & Mr Hyde", 53.91m, "Bantam Books", "https://m.media-amazon.com/images/I/71F0gmdm8pL.jpg", "1982" },
                    { 3, 3, 1, "Harry Potter and the Philosopher's Stone", 30.99m, "Rocco", "https://m.media-amazon.com/images/I/61jgm6ooXzL.jpg", "2000" },
                    { 4, 4, 5, "Por Lugares Incriveis", 60m, "Seguinte", "https://m.media-amazon.com/images/I/510HCDDGb3L._SY344_BO1,204,203,200_QL70_ML2_.jpg", "2015" },
                    { 5, 5, 1, "it a coisa", 45m, "Suma", "https://m.media-amazon.com/images/I/51z0s3GcvwL._SY344_BO1,204,203,200_QL70_ML2_.jpg", "2014" },
                    { 6, 6, 1, "É assim que acaba", 30m, "Galera", "https://m.media-amazon.com/images/I/51i7kH+rh9L._SY344_BO1,204,203,200_.jpg", "2018" },
                    { 7, 7, 1, "A garota do Lago", 80m, "Scholastic Press", "https://m.media-amazon.com/images/I/516VOgxwg2L._SY344_BO1,204,203,200_QL70_ML2_.jpg", "2022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authoes",
                keyColumn: "AuthorId",
                keyValue: 7);
        }
    }
}
