﻿// <auto-generated />
using System;
using EmployeeManagementApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagementApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EmployeeManagementModel.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "CRM"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Media"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Designing"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Management"
                        });
                });

            modelBuilder.Entity("EmployeeManagementModel.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            CreatedDate = new DateTime(2021, 12, 12, 20, 54, 19, 219, DateTimeKind.Local).AddTicks(3540),
                            DepartmentId = 1,
                            EmployementDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(4246),
                            FirstName = "Ahmad",
                            Gender = 0,
                            ImagePath = "Male.png",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Shihab"
                        },
                        new
                        {
                            EmployeeId = 2,
                            CreatedDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(8881),
                            DepartmentId = 2,
                            EmployementDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(8906),
                            FirstName = "Ahmad",
                            Gender = 0,
                            ImagePath = "Male.png",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Saquib"
                        },
                        new
                        {
                            EmployeeId = 3,
                            CreatedDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9023),
                            DepartmentId = 3,
                            EmployementDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9027),
                            FirstName = "Ahmad",
                            Gender = 0,
                            ImagePath = "Male.png",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Tofayel"
                        },
                        new
                        {
                            EmployeeId = 4,
                            CreatedDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9756),
                            DepartmentId = 1,
                            EmployementDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9769),
                            FirstName = "Ahmad",
                            Gender = 0,
                            ImagePath = "Male.png",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nazrul"
                        },
                        new
                        {
                            EmployeeId = 5,
                            CreatedDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9840),
                            DepartmentId = 1,
                            EmployementDate = new DateTime(2021, 12, 12, 20, 54, 19, 222, DateTimeKind.Local).AddTicks(9844),
                            FirstName = "Ahmad",
                            Gender = 1,
                            ImagePath = "Female.png",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Anika"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
