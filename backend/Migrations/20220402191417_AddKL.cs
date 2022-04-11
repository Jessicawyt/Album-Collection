using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_album_collections.Migrations
{
    public partial class AddKL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "HeroImage",
                value: "https://www.alux.com/wp-content/uploads/2017/08/Kendrick-Lamar-Net-Worth-e1501790264974.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "HeroImage",
                value: "/images/kendrick.jpg");
        }
    }
}
