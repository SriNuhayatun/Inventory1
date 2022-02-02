using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory1.Migrations
{
    public partial class Inventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Barang",
                columns: table => new
                {
                    KodeBarang = table.Column<string>(type: "varchar(767)", nullable: false),
                    Kategori = table.Column<string>(type: "text", nullable: false),
                    NamaBarang = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
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
                    Kategori = table.Column<string>(type: "text", nullable: false)
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
                name: "Tb_Keluar",
                columns: table => new
                {
                    Id_Keluar = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBarang1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Keluar", x => x.Id_Keluar);
                    table.ForeignKey(
                        name: "FK_Tb_Keluar_Tb_Barang_KodeBarang1",
                        column: x => x.KodeBarang1,
                        principalTable: "Tb_Barang",
                        principalColumn: "KodeBarang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Masuk",
                columns: table => new
                {
                    Id_Masuk = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBarang1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaBarang = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Masuk", x => x.Id_Masuk);
                    table.ForeignKey(
                        name: "FK_Tb_Masuk_Tb_Barang_KodeBarang1",
                        column: x => x.KodeBarang1,
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
                name: "IX_Tb_Keluar_KodeBarang1",
                table: "Tb_Keluar",
                column: "KodeBarang1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Masuk_KodeBarang1",
                table: "Tb_Masuk",
                column: "KodeBarang1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Kategori");

            migrationBuilder.DropTable(
                name: "Tb_Keluar");

            migrationBuilder.DropTable(
                name: "Tb_Masuk");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_Barang");

            migrationBuilder.DropTable(
                name: "Tb_Roles");
        }
    }
}
