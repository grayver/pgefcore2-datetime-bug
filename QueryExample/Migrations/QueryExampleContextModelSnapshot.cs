﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using QueryExample.EntityFramework;
using System;

namespace QueryExample.Migrations
{
    [DbContext(typeof(QueryExampleContext))]
    partial class QueryExampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("QueryExample.Entities.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BasePrice");

                    b.Property<TimeSpan?>("BaseSubscriptionDuration");

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<bool>("IsSubscription");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("ShopItem");
                });

            modelBuilder.Entity("QueryExample.Entities.ShopOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("CreatedAt");

                    b.Property<DateTimeOffset?>("ExpiresAt");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int?>("Position");

                    b.Property<int?>("ShopItemId");

                    b.Property<TimeSpan?>("SubscriptionDuration");

                    b.HasKey("Id");

                    b.HasIndex("ShopItemId");

                    b.ToTable("ShopOffers");
                });

            modelBuilder.Entity("QueryExample.Entities.ShopOffer", b =>
                {
                    b.HasOne("QueryExample.Entities.ShopItem", "Item")
                        .WithMany()
                        .HasForeignKey("ShopItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
