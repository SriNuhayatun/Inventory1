﻿// <auto-generated />
using Inventory1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220203081401_Tb_BarangMasuk")]
    partial class Tb_BarangMasuk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Inventory1.Models.BarangKeluar", b =>
                {
                    b.Property<string>("Id_Keluar")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBarang1")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaBarang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id_Keluar");

                    b.HasIndex("KodeBarang1");

                    b.ToTable("Tb_Keluar");
                });

            modelBuilder.Entity("Inventory1.Models.BarangMasuk", b =>
                {
                    b.Property<string>("Id_Masuk")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBarang1")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaBarang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id_Masuk");

                    b.HasIndex("KodeBarang1");

                    b.ToTable("Tb_Masuk");
                });

            modelBuilder.Entity("Inventory1.Models.DataBarang", b =>
                {
                    b.Property<string>("KodeBarang")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NamaBarang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("KodeBarang");

                    b.ToTable("Tb_Barang");
                });

            modelBuilder.Entity("Inventory1.Models.DataKategori", b =>
                {
                    b.Property<string>("id_kategori")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_kategori");

                    b.ToTable("Tb_Kategori");
                });

            modelBuilder.Entity("Inventory1.Models.Db_BarangMasuk", b =>
                {
                    b.Property<string>("Id_Masuk")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBarang")
                        .HasColumnType("text");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("Id_Masuk");

                    b.ToTable("Tb_BarangMasuk");
                });

            modelBuilder.Entity("Inventory1.Models.Roles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tb_Roles");
                });

            modelBuilder.Entity("Inventory1.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("RolesId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Username");

                    b.HasIndex("RolesId");

                    b.ToTable("Tb_User");
                });

            modelBuilder.Entity("Inventory1.Models.BarangKeluar", b =>
                {
                    b.HasOne("Inventory1.Models.DataBarang", "KodeBarang")
                        .WithMany()
                        .HasForeignKey("KodeBarang1");

                    b.Navigation("KodeBarang");
                });

            modelBuilder.Entity("Inventory1.Models.BarangMasuk", b =>
                {
                    b.HasOne("Inventory1.Models.DataBarang", "KodeBarang")
                        .WithMany()
                        .HasForeignKey("KodeBarang1");

                    b.Navigation("KodeBarang");
                });

            modelBuilder.Entity("Inventory1.Models.User", b =>
                {
                    b.HasOne("Inventory1.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
