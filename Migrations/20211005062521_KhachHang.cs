using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class KhachHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaNV = table.Column<int>(type: "INTEGER", nullable: false),
                    TenNV = table.Column<string>(type: "TEXT", nullable: true),
                    TenPhong = table.Column<string>(type: "TEXT", nullable: true),
                    SDT = table.Column<int>(type: "INTEGER", nullable: false),
                    GioiTinh = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
