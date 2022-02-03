using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory1.Migrations
{
    public partial class addForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KodeBarang",
                table: "Tb_BarangMasuk",
                type: "varchar(767)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_BarangMasuk_KodeBarang",
                table: "Tb_BarangMasuk",
                column: "KodeBarang");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_BarangMasuk_Tb_Barang_KodeBarang",
                table: "Tb_BarangMasuk",
                column: "KodeBarang",
                principalTable: "Tb_Barang",
                principalColumn: "KodeBarang",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_BarangMasuk_Tb_Barang_KodeBarang",
                table: "Tb_BarangMasuk");

            migrationBuilder.DropIndex(
                name: "IX_Tb_BarangMasuk_KodeBarang",
                table: "Tb_BarangMasuk");

            migrationBuilder.AlterColumn<string>(
                name: "KodeBarang",
                table: "Tb_BarangMasuk",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(767)",
                oldNullable: true);
        }
    }
}
