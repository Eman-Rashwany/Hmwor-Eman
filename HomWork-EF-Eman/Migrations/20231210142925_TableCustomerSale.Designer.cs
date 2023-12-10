﻿// <auto-generated />
using System;
using HomWork_EF_Eman;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomWork_EF_Eman.Migrations
{
    [DbContext(typeof(ApplictionDbContext1))]
    [Migration("20231210142925_TableCustomerSale")]
    partial class TableCustomerSale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HomWork_EF_Eman.Car", b =>
                {
                    b.Property<int>("CARId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CARId"));

                    b.Property<int>("Gear")
                        .HasColumnType("int");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CARId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("HomWork_EF_Eman.CarParte", b =>
                {
                    b.Property<int>("CARId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Addedon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("CARId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("CarParte");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersId1")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuppliersId");

                    b.HasIndex("SuppliersId1");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("CustomerId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Suppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("HomWork_EF_Eman.CarParte", b =>
                {
                    b.HasOne("HomWork_EF_Eman.Car", "Car")
                        .WithMany("CarPartes")
                        .HasForeignKey("CARId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomWork_EF_Eman.Part", "Part")
                        .WithMany("CarPartes")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Part");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Customer", b =>
                {
                    b.HasOne("HomWork_EF_Eman.Customer", null)
                        .WithMany("Customers")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Part", b =>
                {
                    b.HasOne("HomWork_EF_Eman.Suppliers", null)
                        .WithMany("Parts")
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomWork_EF_Eman.Suppliers", "Suppliers")
                        .WithMany()
                        .HasForeignKey("SuppliersId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Sale", b =>
                {
                    b.HasOne("HomWork_EF_Eman.Car", "Car")
                        .WithOne("Sale")
                        .HasForeignKey("HomWork_EF_Eman.Sale", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomWork_EF_Eman.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Car", b =>
                {
                    b.Navigation("CarPartes");

                    b.Navigation("Sale")
                        .IsRequired();
                });

            modelBuilder.Entity("HomWork_EF_Eman.Customer", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Part", b =>
                {
                    b.Navigation("CarPartes");
                });

            modelBuilder.Entity("HomWork_EF_Eman.Suppliers", b =>
                {
                    b.Navigation("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}