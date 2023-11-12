﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06.Shared.Books.Book", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(8,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Author = "Sydney Roberts",
                            Title = "maiores"
                        },
                        new
                        {
                            Id = 2m,
                            Author = "Myrtice Beahan",
                            Title = "vel"
                        },
                        new
                        {
                            Id = 3m,
                            Author = "Camden Dietrich",
                            Title = "sit"
                        },
                        new
                        {
                            Id = 4m,
                            Author = "Tabitha Kunze",
                            Title = "et"
                        },
                        new
                        {
                            Id = 5m,
                            Author = "Jailyn Block",
                            Title = "consectetur"
                        },
                        new
                        {
                            Id = 6m,
                            Author = "Kennith Gaylord",
                            Title = "nulla"
                        },
                        new
                        {
                            Id = 7m,
                            Author = "Tristin Cronin",
                            Title = "consequatur"
                        },
                        new
                        {
                            Id = 8m,
                            Author = "Orval Abernathy",
                            Title = "accusantium"
                        },
                        new
                        {
                            Id = 9m,
                            Author = "Louvenia Pfannerstill",
                            Title = "facere"
                        },
                        new
                        {
                            Id = 10m,
                            Author = "Jovan Connelly",
                            Title = "eveniet"
                        },
                        new
                        {
                            Id = 11m,
                            Author = "Royal Rosenbaum",
                            Title = "mollitia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
