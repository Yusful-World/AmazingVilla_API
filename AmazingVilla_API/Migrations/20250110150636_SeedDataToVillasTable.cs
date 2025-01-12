using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AmazingVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToVillasTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "DateCreated", "DateUpdated", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[,]
                {
                    { 1, "Boat rides, Jet skiing, Beach Volleyball", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5451), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5462), "A serene and popular beach accessible only by boat.", "https://example.com/tarkwa.jpg", "Tarkwa Bay Beach", 10, 5000.0, 4000 },
                    { 2, "Bars, Restaurants, Live Music", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5464), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5465), "A vibrant private beach known for its nightlife.", "https://example.com/elegushi.jpg", "Elegushi Beach", 8, 7000.0, 3500 },
                    { 3, "Beach chairs, Grills, Lounges", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5467), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5468), "A private beach with a relaxed atmosphere.", "https://example.com/oniru.jpg", "Oniru Beach", 6, 6000.0, 3000 },
                    { 4, "Swimming, Horse Riding, Snacks", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5469), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5470), "A popular beach for families and fun activities.", "https://example.com/lekki.jpg", "Lekki Beach", 12, 4000.0, 5000 },
                    { 5, "Luxury cabanas, Restaurants, Water sports", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5472), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5472), "An exclusive beach with modern facilities.", "https://example.com/landmark.jpg", "Landmark Beach", 15, 10000.0, 4500 },
                    { 6, "Luxury housing, Scenic views, High security", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5474), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5475), "A prestigious island known for its exclusivity.", "https://example.com/banana.jpg", "Banana Island", 20, 15000.0, 7000 },
                    { 7, "Business hubs, High-end hotels, Waterfronts", new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 1, 10, 16, 6, 35, 783, DateTimeKind.Local).AddTicks(5477), "A cosmopolitan island with top-notch facilities.", "https://example.com/victoria.jpg", "Victoria Island", 18, 8000.0, 6000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
