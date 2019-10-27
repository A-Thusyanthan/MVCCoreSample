﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191027051944_BackToNormal")]
    partial class BackToNormal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalRequest")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateRegistered");

                    b.Property<bool>("Day1");

                    b.Property<bool>("Day2");

                    b.Property<bool>("Day3");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new { Id = 1, AdditionalRequest = "Act", DateRegistered = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Day1 = false, Day2 = false, Day3 = true, Email = "thus@gmail.com", Gender = "M", Name = "Thus" },
                        new { Id = 2, AdditionalRequest = "Act", DateRegistered = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Day1 = true, Day2 = true, Day3 = false, Email = "ram@gmail.com", Gender = "M", Name = "Ram" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
