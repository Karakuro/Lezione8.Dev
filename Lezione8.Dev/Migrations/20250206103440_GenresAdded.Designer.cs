﻿// <auto-generated />
using Lezione8.Dev.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lezione8.Dev.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20250206103440_GenresAdded")]
    partial class GenresAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Lezione8.Dev.Data.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ShelfId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("ShelfId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Shelf", b =>
                {
                    b.Property<int>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ShelfId");

                    b.HasIndex("GenreId");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Book", b =>
                {
                    b.HasOne("Lezione8.Dev.Data.Shelf", "Shelf")
                        .WithMany("Books")
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Shelf", b =>
                {
                    b.HasOne("Lezione8.Dev.Data.Genre", "Genre")
                        .WithMany("Shelves")
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Genre", b =>
                {
                    b.Navigation("Shelves");
                });

            modelBuilder.Entity("Lezione8.Dev.Data.Shelf", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
