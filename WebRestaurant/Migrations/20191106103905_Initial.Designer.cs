﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebRestaurant.Data;

namespace WebRestaurant.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20191106103905_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebRestaurant.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("categoreName");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebRestaurant.Data.Models.Dishes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("available");

                    b.Property<int>("categoryID");

                    b.Property<string>("dishName");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesc");

                    b.Property<int>("price");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("WebRestaurant.Data.Models.Dishes", b =>
                {
                    b.HasOne("WebRestaurant.Data.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
