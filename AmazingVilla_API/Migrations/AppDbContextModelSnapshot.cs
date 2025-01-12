﻿// <auto-generated />
using System;
using AmazingVilla_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmazingVilla_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmazingVilla_API.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Boat rides, Jet skiing, Beach Volleyball",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5451),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5462),
                            Details = "A serene and popular beach accessible only by boat.",
                            ImageUrl = "https://example.com/tarkwa.jpg",
                            Name = "Tarkwa Bay Beach",
                            Occupancy = 10,
                            Rate = 5000.0,
                            Sqft = 4000
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Bars, Restaurants, Live Music",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5464),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5465),
                            Details = "A vibrant private beach known for its nightlife.",
                            ImageUrl = "https://example.com/elegushi.jpg",
                            Name = "Elegushi Beach",
                            Occupancy = 8,
                            Rate = 7000.0,
                            Sqft = 3500
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Beach chairs, Grills, Lounges",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5467),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5468),
                            Details = "A private beach with a relaxed atmosphere.",
                            ImageUrl = "https://example.com/oniru.jpg",
                            Name = "Oniru Beach",
                            Occupancy = 6,
                            Rate = 6000.0,
                            Sqft = 3000
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Swimming, Horse Riding, Snacks",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5469),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5470),
                            Details = "A popular beach for families and fun activities.",
                            ImageUrl = "https://example.com/lekki.jpg",
                            Name = "Lekki Beach",
                            Occupancy = 12,
                            Rate = 4000.0,
                            Sqft = 5000
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Luxury cabanas, Restaurants, Water sports",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5472),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5472),
                            Details = "An exclusive beach with modern facilities.",
                            ImageUrl = "https://example.com/landmark.jpg",
                            Name = "Landmark Beach",
                            Occupancy = 15,
                            Rate = 10000.0,
                            Sqft = 4500
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "Luxury housing, Scenic views, High security",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5474),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5475),
                            Details = "A prestigious island known for its exclusivity.",
                            ImageUrl = "https://example.com/banana.jpg",
                            Name = "Banana Island",
                            Occupancy = 20,
                            Rate = 15000.0,
                            Sqft = 7000
                        },
                        new
                        {
                            Id = 7,
                            Amenity = "Business hubs, High-end hotels, Waterfronts",
                            DateCreated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5476),
                            DateUpdated = new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5477),
                            Details = "A cosmopolitan island with top-notch facilities.",
                            ImageUrl = "https://example.com/victoria.jpg",
                            Name = "Victoria Island",
                            Occupancy = 18,
                            Rate = 8000.0,
                            Sqft = 6000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}