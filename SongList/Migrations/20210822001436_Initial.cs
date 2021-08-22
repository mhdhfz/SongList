using Microsoft.EntityFrameworkCore.Migrations;

namespace SongList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 1, "Assalamualaikum", 5, 2018 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 2, "Dewi Puspita", 4, 2021 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 3, "Nak Dara Rindu", 3, 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
