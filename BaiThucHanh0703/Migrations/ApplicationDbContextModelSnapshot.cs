﻿// <auto-generated />
using BaiThucHanh0703.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucHanh0703.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("BaiThucHanh0703.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
