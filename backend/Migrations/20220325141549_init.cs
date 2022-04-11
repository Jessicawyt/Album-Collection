using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_album_collections.Migrations
{
    public partial class init : Migration
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

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Genre", "HeroImage", "Name" },
                values: new object[,]
                {
                    { 1, "Kendrick Lamar is an American rapper and lyricist. He is a critically and commercially acclaimed artist who started his musical journey as a teenager. He began his career in music by recording mix tapes under the pseudonym K-Dot. His first musical contract was signed at the age of sixteen with record label Top Dawg Entertainment.", "Rap", "/images/kendrick.jpg", "Kendrick Lamar" },
                    { 2, "Miley Ray Cyrus is an American singer, songwriter, actress, and television personality. Known for her distinctive raspy voice, her music incorporates elements of varied styles and genres, including pop, country pop, hip hop, experimental, and rock. She has attained the most US Billboard 200 top-five albums in the 21st century by a female artist, with a total of thirteen entries", "Pop", "/images/miley.jpg", "Miley Cyrus" },
                    { 3, "Abel Makkonen Tesfaye, professionally known as 'The Weeknd' is a Canadian singer born February 16, 1990 in Toronto. Best known for his performances in his latest album 'Starboy' (2016), and numerous other productions including 'Kissland' (2013), Beauty Behind the Madness (2015) which included the mega-hit; 'The Hills', and House of Balloons, Thursday and Echoes of Silence.", "R&B", "/images/theweekend.webp", "The Weekend" },
                    { 4, "Carrie Underwood was born on March 10, 1983 in Muskogee, Oklahoma, USA. She is known for Soul Surfer (2011), American Idol (2002) and The Chronicles of Narnia: The Voyage of the Dawn Treader (2010).", "Country", "https://townsquare.media/site/204/files/2019/11/Carrie-Underwood-Cries-Pretty.jpg?w=1200&h=0&zc=1&s=0&a=t&q=89", "Carrier Underwood" },
                    { 5, "Pink Floyd is a progressive rock band formed in 1965 in Cambridge & London, England, active since 1965 through 1983 & 1987 to present. Group's main members are Syd Barrett, Roger Waters, David Gilmour, Nick Mason, Rick Wright. ", "Rock", "https://th.bing.com/th/id/OIP.M5rS4qWkb6RfHK6LB5X_dAHaE8?pid=ImgDet&rs=1", "Pink Floyd" },
                    { 6, "Nicolás Jaar is a Chilean-American composer and recording artist based in New York. Among his notable works are the albums Space Is Only Noise, Sirens, and Cenizas. He has also released two albums as one half of his band Darkside and two further albums under the alias Against All Logic.", "Electronic", "https://vinilogarage.cl/wp-content/uploads/2021/03/UGZV2SHRX5DLFK5V6SQ5MKHGSY.jpg", "Nicolás Jaar" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "RecordLabel", "Title" },
                values: new object[,]
                {
                    { 1, 1, "https://th.bing.com/th/id/OIP.QIo4l4lnGh-JcY5_x65DMgHaHa?pid=ImgDet&rs=1", "Aftermath", "DAMN." },
                    { 21, 4, "", "RecordLabel", "Album" },
                    { 22, 4, "", "RecordLabel", "Album" },
                    { 23, 4, "", "RecordLabel", "Album" },
                    { 24, 4, "", "RecordLabel", "Album" },
                    { 25, 5, "", "RecordLabel", "Album" },
                    { 26, 5, "", "RecordLabel", "Album" },
                    { 20, 4, "", "RecordLabel", "Album" },
                    { 27, 5, "", "RecordLabel", "Album" },
                    { 29, 5, "", "RecordLabel", "Album" },
                    { 30, 5, "", "RecordLabel", "Album" },
                    { 31, 6, "", "RecordLabel", "Album" },
                    { 32, 6, "", "RecordLabel", "Album" },
                    { 33, 6, "", "RecordLabel", "Album" },
                    { 34, 6, "", "RecordLabel", "Album" },
                    { 28, 5, "", "RecordLabel", "Black Panther" },
                    { 19, 4, "", "RecordLabel", "Album" },
                    { 18, 3, "", "RecordLabel", "Album" },
                    { 17, 3, "", "RecordLabel", "Album" },
                    { 2, 1, "https://www.latercera.com/resizer/rIGTLbi8ie_DpkFAJRxkq5vI8W4=/900x600/smart/arc-anglerfish-arc2-prod-copesa.s3.amazonaws.com/public/L2EHWPGBSNA45DUPSXB2CHIYPU.jpg", "Aftermath", "To Pimp a Butterfly" },
                    { 3, 1, "https://th.bing.com/th/id/OIP.IPKkOHP67lCEhUFeeeyhYwHaHa?pid=ImgDet&rs=1", "Aftermath", "Good Kid, M.A.A.D. City" },
                    { 4, 1, "https://images.complex.com/complex/images/c_fill,g_center,h_300,q_auto,w_600/fl_lossy,pg_1/nmbw4qiwlch9sla2tcpz/kendrick-lamar-section-80-album-cover", "Top Dawg Entertainment", "Section.80" },
                    { 5, 1, "https://th.bing.com/th/id/R.48707a67ae5ea6e7d6704260536d477a?rik=DIWtz3R7GyygfQ&riu=http%3a%2f%2fimg.wennermedia.com%2fsocial%2frs-kendrick-lamar-untitled-unmastered-87205fdc-0504-4a57-858d-8d45151dcfb6.jpg&ehk=7tiuN1XFL9cfekR4Fs69ujMvkyuuZyaHIf1j3icB82g%3d&risl=&pid=ImgRaw&r=0", "Aftermath", "untitled unmastered." },
                    { 6, 1, "https://th.bing.com/th/id/OIP.orohBwmwTTKsR-SA_lRjcAHaEP?pid=ImgDet&rs=1", "Interscope", "Black Panther" },
                    { 7, 2, "https://i.pinimg.com/originals/38/e0/6e/38e06ed03db63c6d75338a5a76b3135b.png", "RCA Records", "Plastic Hearts" },
                    { 8, 2, "", "RecordLabel", "Album" },
                    { 9, 2, "", "RecordLabel", "Album" },
                    { 10, 2, "", "RecordLabel", "Album" },
                    { 11, 2, "", "RecordLabel", "Album" },
                    { 12, 2, "", "RecordLabel", "Album" },
                    { 13, 3, "https://m.media-amazon.com/images/I/81-blrK5yoL._SL1400_.jpg", "XO", "Album" },
                    { 14, 3, "", "RecordLabel", "Album" },
                    { 15, 3, "", "RecordLabel", "Album" },
                    { 16, 3, "", "RecordLabel", "Album" },
                    { 35, 6, "", "RecordLabel", "Album" },
                    { 36, 6, "", "RecordLabel", "Album" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "ReviewerName" },
                values: new object[,]
                {
                    { 1, 1, "My boyfriend fave album", "Miranda" },
                    { 2, 7, "I really wish she could do better", "user05079786" },
                    { 31, 6, "Listening in my car", "user005955857" },
                    { 25, 5, "Love it", "Landon" },
                    { 3, 13, "Love him!Praying for him every night<3", "TheWeekandJunkie" },
                    { 4, 19, "Not my type of music", "Sammy" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Title" },
                values: new object[,]
                {
                    { 6, 2, "The Climb" },
                    { 1, 1, "Loyalty ft. Rihanna" },
                    { 2, 1, "Lust" },
                    { 3, 1, "DNA" },
                    { 22, 3, "Song" },
                    { 21, 3, "Song" },
                    { 20, 3, "Song" },
                    { 19, 3, "Song" },
                    { 18, 3, "Song" },
                    { 5, 1, "Blood" },
                    { 17, 3, "Song" },
                    { 14, 3, "Wicked Games" },
                    { 4, 1, "Feel" },
                    { 12, 2, "Angels Like You" },
                    { 11, 2, "Prisoner (FEAT. DUA LIPA)" },
                    { 10, 2, "Alright" },
                    { 9, 2, "Start All Over" },
                    { 8, 2, "7 Things" },
                    { 7, 2, "We Can't Stop" },
                    { 16, 3, "Song" },
                    { 13, 3, "The Morning" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AlbumId",
                table: "Reviews",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
