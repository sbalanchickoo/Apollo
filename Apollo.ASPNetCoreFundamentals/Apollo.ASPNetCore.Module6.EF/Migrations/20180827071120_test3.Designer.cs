﻿// <auto-generated />
using Apollo.ASPNetCore.Module6.RestaurantReviews.EFModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20180827071120_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CuisineName");

                    b.HasKey("CuisineId");

                    b.ToTable("Cuisine");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Greeting", b =>
                {
                    b.Property<int>("GreetingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message");

                    b.HasKey("GreetingId");

                    b.ToTable("Greeting");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.HeadChef", b =>
                {
                    b.Property<int>("HeadChefId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeadChefName");

                    b.Property<int>("RestaurantId");

                    b.HasKey("HeadChefId");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("HeadChef");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeadChefId");

                    b.Property<int>("RestaurantBudget");

                    b.Property<string>("RestaurantLocation")
                        .IsRequired();

                    b.Property<string>("RestaurantName")
                        .IsRequired();

                    b.Property<decimal>("RestaurantRating");

                    b.HasKey("RestaurantId");

                    b.HasIndex("HeadChefId")
                        .IsUnique();

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.RestaurantCuisine", b =>
                {
                    b.Property<int>("RestaurantId");

                    b.Property<int>("CuisineId");

                    b.HasKey("RestaurantId", "CuisineId");

                    b.HasIndex("CuisineId");

                    b.ToTable("RestaurantCuisine");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.HeadChef", b =>
                {
                    b.HasOne("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Restaurant", "Restaurant")
                        .WithOne("HeadChef")
                        .HasForeignKey("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.HeadChef", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.RestaurantCuisine", b =>
                {
                    b.HasOne("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Cuisine", "Cuisine")
                        .WithMany()
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantCuisines")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
