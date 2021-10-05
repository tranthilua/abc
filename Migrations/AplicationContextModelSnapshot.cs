﻿// <auto-generated />
using System;
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMVC.Migrations
{
    [DbContext(typeof(AplicationContext))]
    partial class AplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("DemoMVC.Models.KhachHang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaNV")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SDT")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenPhong")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DemoMVC.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DemoMVC.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Khoa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lop")
                        .HasColumnType("TEXT");

                    b.Property<int>("Masinhvien")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
