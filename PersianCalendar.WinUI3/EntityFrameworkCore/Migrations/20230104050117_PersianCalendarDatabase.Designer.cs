﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersianCalendar.WinUI3.Database;

#nullable disable

namespace PersianCalendar.WinUI3.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230104050117_PersianCalendarDatabase")]
    partial class PersianCalendarDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("PersianCalendar.WinUI3.Database.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ShiftPatternId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShiftTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });
#pragma warning restore 612, 618
        }
    }
}