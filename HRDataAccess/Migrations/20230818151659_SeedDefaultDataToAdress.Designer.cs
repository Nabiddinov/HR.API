﻿// <auto-generated />
using System;
using HRDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRDataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230818151659_SeedDefaultDataToAdress")]
    partial class SeedDefaultDataToAdress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRDataAccess.Entites.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddresLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddresLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            AddresLine1 = "1,Parkent tumani",
                            AddresLine2 = "2,Boyqozon Qo'rg'on",
                            City = "Tashkent",
                            Country = "Uzbekistan",
                            Postalcode = "777777"
                        });
                });

            modelBuilder.Entity("HRDataAccess.Entites.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("Departament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'nabiddinov@gmail.com'");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WrongProp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HRDataAccess.Entites.Employee", b =>
                {
                    b.HasOne("HRDataAccess.Entites.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");

                    b.Navigation("Adress");
                });
#pragma warning restore 612, 618
        }
    }
}
