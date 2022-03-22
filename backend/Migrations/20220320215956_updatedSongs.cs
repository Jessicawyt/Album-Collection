using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_album_collections.Migrations
{
    public partial class updatedSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Angels Like You");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Angles Like You");
        }
    }
}
