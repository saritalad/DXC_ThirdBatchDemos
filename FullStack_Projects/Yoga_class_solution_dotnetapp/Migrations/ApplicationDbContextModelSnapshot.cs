﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetapp.Models;

#nullable disable

namespace dotnetapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnetapp.Models.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchID"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BatchID");

                    b.ToTable("Batches");

                    b.HasData(
                        new
                        {
                            BatchID = 1,
                            Capacity = 5,
                            EndTime = new DateTime(2024, 7, 9, 2, 0, 0, 0, DateTimeKind.Local),
                            StartTime = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BatchID = 2,
                            Capacity = 5,
                            EndTime = new DateTime(2024, 8, 18, 1, 0, 0, 0, DateTimeKind.Local),
                            StartTime = new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BatchID = 3,
                            Capacity = 5,
                            EndTime = new DateTime(2024, 11, 26, 1, 0, 0, 0, DateTimeKind.Local),
                            StartTime = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BatchID = 4,
                            Capacity = 5,
                            EndTime = new DateTime(2025, 3, 6, 1, 0, 0, 0, DateTimeKind.Local),
                            StartTime = new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BatchID = 5,
                            Capacity = 5,
                            EndTime = new DateTime(2025, 6, 14, 1, 0, 0, 0, DateTimeKind.Local),
                            StartTime = new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("dotnetapp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("BatchID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("dotnetapp.Models.Student", b =>
                {
                    b.HasOne("dotnetapp.Models.Batch", "Batch")
                        .WithMany("Students")
                        .HasForeignKey("BatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");
                });

            modelBuilder.Entity("dotnetapp.Models.Batch", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
