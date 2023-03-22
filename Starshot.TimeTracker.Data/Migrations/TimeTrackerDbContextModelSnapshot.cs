﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starshot.TimeTracker.Data;

#nullable disable

namespace Starshot.TimeTracker.Data.Migrations
{
    [DbContext(typeof(TimeTrackerDbContext))]
    partial class TimeTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Starshot.TimeTracker.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Starshot.TimeTracker.Data.Models.TimeSheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ClockIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ClockOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserIdFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserIdFk");

                    b.ToTable("TimeSheets");
                });

            modelBuilder.Entity("Starshot.TimeTracker.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            Password = "EWg/egxSYtJF09Yk27BMmZLgRzxvb9S8ITepAmtekntplRI19QLSXp4PR1rrVc8y",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Starshot.TimeTracker.Data.Models.TimeSheet", b =>
                {
                    b.HasOne("Starshot.TimeTracker.Data.Models.Employee", "Employee")
                        .WithMany("TimeSheets")
                        .HasForeignKey("UserIdFk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Starshot.TimeTracker.Data.Models.Employee", b =>
                {
                    b.Navigation("TimeSheets");
                });
#pragma warning restore 612, 618
        }
    }
}