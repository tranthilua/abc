using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hoten = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Masinhvien = table.Column<int>(type: "INTEGER", nullable: false),
                    Lop = table.Column<string>(type: "TEXT", nullable: true),
                    Khoa = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
