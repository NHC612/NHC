﻿// <auto-generated />
using BaiThucHanh0703.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucHanh0703.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230409074231_Create_Table_Student")]
    partial class Create_Table_Student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("BaiThucHanh0703.Models.Student", b =>
                {
                    b.Property<string>("StudentCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentCode");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
