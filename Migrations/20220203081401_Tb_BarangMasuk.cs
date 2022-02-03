using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory1.Migrations
{
    public partial class Tb_BarangMasuk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_BarangMasuk",
                columns: table => new
                {
                    Id_Masuk = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBarang = table.Column<string>(type: "text", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BarangMasuk", x => x.Id_Masuk);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_BarangMasuk");
        }
    }
}
