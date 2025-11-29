using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesView.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "News");
        }
    }
}
