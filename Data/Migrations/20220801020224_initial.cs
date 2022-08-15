using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Ratings.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalGrade = table.Column<int>(type: "int", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlotGrade = table.Column<int>(type: "int", nullable: false),
                    PlotDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CineGrade = table.Column<int>(type: "int", nullable: false),
                    CineDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicGrade = table.Column<int>(type: "int", nullable: false),
                    MusicDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActingGrade = table.Column<int>(type: "int", nullable: false),
                    ActingDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VFXGrade = table.Column<int>(type: "int", nullable: false),
                    VFXDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
