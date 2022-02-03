﻿// <auto-generated />
using Inventory1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220203093721_Tb_User")]
    partial class Tb_User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Inventory1.Models.DataBarang", b =>
                {
                    b.Property<string>("KodeBarang")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Kategori")
                        .HasColumnType("text");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("text");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("KodeBarang");

                    b.ToTable("Tb_Barang");
                });

            modelBuilder.Entity("Inventory1.Models.DataKategori", b =>
                {
                    b.Property<string>("id_kategori")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Kategori")
                        .HasColumnType("text");

                    b.HasKey("id_kategori");

                    b.ToTable("Tb_Kategori");
                });

            modelBuilder.Entity("Inventory1.Models.Db_BarangKeluar", b =>
                {
                    b.Property<string>("Id_Keluar")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBarang")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("Id_Keluar");

                    b.HasIndex("KodeBarang");

                    b.ToTable("Tb_BarangKeluar");
                });

            modelBuilder.Entity("Inventory1.Models.Db_BarangMasuk", b =>
                {
                    b.Property<string>("Id_Masuk")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBarang")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("Id_Masuk");

                    b.HasIndex("KodeBarang");

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

            modelBuilder.Entity("Inventory1.Models.Db_BarangKeluar", b =>
                {
                    b.HasOne("Inventory1.Models.DataBarang", "KodeBrg")
                        .WithMany()
                        .HasForeignKey("KodeBarang");

                    b.Navigation("KodeBrg");
                });

            modelBuilder.Entity("Inventory1.Models.Db_BarangMasuk", b =>
                {
                    b.HasOne("Inventory1.Models.DataBarang", "KodeBrg")
                        .WithMany()
                        .HasForeignKey("KodeBarang");

                    b.Navigation("KodeBrg");
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