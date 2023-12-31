﻿// <auto-generated />
using System;
using ASPNETMVCCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNETMVCCRUD.Migrations
{
    [DbContext(typeof(MVCDemoDbContext))]
    [Migration("20230822205347_ii")]
    partial class ii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASPNETMVCCRUD.Models.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ASPNETMVCCRUD.Models.Domain.Student", b =>
                {
                    b.Property<string>("S_Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("S_DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("S_Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("S_Email");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
