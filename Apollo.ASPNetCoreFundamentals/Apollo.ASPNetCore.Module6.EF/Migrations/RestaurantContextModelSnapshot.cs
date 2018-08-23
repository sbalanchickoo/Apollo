﻿// <auto-generated />
using System;
using Apollo.ASPNetCore.Module6.RestaurantReviews.EFModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Cuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("RestaurantId");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Cuisine");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Rating");

                    b.Property<int>("RestaurantBudget");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Cuisine", b =>
                {
                    b.HasOne("Apollo.ASPNetCore.Module6.RestaurantReviews.Models.Restaurant")
                        .WithMany("Cuisine")
                        .HasForeignKey("RestaurantId");
                });
#pragma warning restore 612, 618
        }
    }
}
