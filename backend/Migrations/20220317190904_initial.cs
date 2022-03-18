using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_album_collections.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Genre", "HeroImage", "Name" },
                values: new object[] { 1, "Born in compton", "Rap", "/images/kendrick.jpg", "Kendrick Lamar" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Genre", "HeroImage", "Name" },
                values: new object[] { 2, "Daughter of Billy Ray", "Pop", "/images/miley.jpg", "Miley Cyrus" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Genre", "HeroImage", "Name" },
                values: new object[] { 3, "Abel Makkonen Tefaye, Known professionally as the Weekend", "R&B", "/images/theweekend.webp", "The Weekend" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
