using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarySystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class QuotesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuoteText = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The text of the quote"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The name of the author, that said the quote")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
