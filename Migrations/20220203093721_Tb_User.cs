using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory1.Migrations
{
    public partial class Tb_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Barang",
                columns: table => new
                {
                    KodeBarang = table.Column<string>(type: "varchar(767)", nullable: false),
                    Kategori = table.Column<string>(type: "text", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    Stok = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Barang", x => x.KodeBarang);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kategori",
                columns: table => new
                {
                    id_kategori = table.Column<string>(type: "varchar(767)", nullable: false),
                    Kategori = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kategori", x => x.id_kategori);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_BarangKeluar",
                columns: table => new
                {
                    Id_Keluar = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBarang = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BarangKeluar", x => x.Id_Keluar);
                    table.ForeignKey(
                        name: "FK_Tb_BarangKeluar_Tb_Barang_KodeBarang",
                        column: x => x.KodeBarang,
                        principalTable: "Tb_Barang",
                        principalColumn: "KodeBarang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_BarangMasuk",
                columns: table => new
                {
                    Id_Masuk = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBarang = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BarangMasuk", x => x.Id_Masuk);
                    table.ForeignKey(
                        name: "FK_Tb_BarangMasuk_Tb_Barang_KodeBarang",
                        column: x => x.KodeBarang,
                        principalTable: "Tb_Barang",
                        principalColumn: "KodeBarang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    Username = table.Column<string>(type: "varchar(767)", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    RolesId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_User", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Tb_User_Tb_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Tb_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_BarangKeluar_KodeBarang",
                table: "Tb_BarangKeluar",
                column: "KodeBarang");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_BarangMasuk_KodeBarang",
                table: "Tb_BarangMasuk",
                column: "KodeBarang");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_BarangKeluar");

            migrationBuilder.DropTable(
                name: "Tb_BarangMasuk");

            migrationBuilder.DropTable(
                name: "Tb_Kategori");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_Barang");

            migrationBuilder.DropTable(
                name: "Tb_Roles");
        }
    }
}
