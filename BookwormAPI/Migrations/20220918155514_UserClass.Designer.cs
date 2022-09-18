﻿// <auto-generated />
using BookwormAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookwormAPI.Solution.Migrations
{
    [DbContext(typeof(BookwormAPIContext))]
    [Migration("20220918155514_UserClass")]
    partial class UserClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookwormAPI.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AgeRange")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Author")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rating")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tags")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookwormAPI.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("TheReview")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookwormAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookwormAPI.Models.Review", b =>
                {
                    b.HasOne("BookwormAPI.Models.Book", null)
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookwormAPI.Models.User", null)
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookwormAPI.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookwormAPI.Models.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
