using AmazingVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazingVilla_API.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Tarkwa Bay Beach",
                    Details = "A serene and popular beach accessible only by boat.",
                    Rate = 5000.00,
                    Sqft = 4000,
                    Occupancy = 10,
                    ImageUrl = "https://example.com/tarkwa.jpg",
                    Amenity = "Boat rides, Jet skiing, Beach Volleyball",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Elegushi Beach",
                    Details = "A vibrant private beach known for its nightlife.",
                    Rate = 7000.00,
                    Sqft = 3500,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/elegushi.jpg",
                    Amenity = "Bars, Restaurants, Live Music",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Oniru Beach",
                    Details = "A private beach with a relaxed atmosphere.",
                    Rate = 6000.00,
                    Sqft = 3000,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/oniru.jpg",
                    Amenity = "Beach chairs, Grills, Lounges",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    Name = "Lekki Beach",
                    Details = "A popular beach for families and fun activities.",
                    Rate = 4000.00,
                    Sqft = 5000,
                    Occupancy = 12,
                    ImageUrl = "https://example.com/lekki.jpg",
                    Amenity = "Swimming, Horse Riding, Snacks",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    Name = "Landmark Beach",
                    Details = "An exclusive beach with modern facilities.",
                    Rate = 10000.00,
                    Sqft = 4500,
                    Occupancy = 15,
                    ImageUrl = "https://example.com/landmark.jpg",
                    Amenity = "Luxury cabanas, Restaurants, Water sports",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 6,
                    Name = "Banana Island",
                    Details = "A prestigious island known for its exclusivity.",
                    Rate = 15000.00,
                    Sqft = 7000,
                    Occupancy = 20,
                    ImageUrl = "https://example.com/banana.jpg",
                    Amenity = "Luxury housing, Scenic views, High security",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Villa
                {
                    Id = 7,
                    Name = "Victoria Island",
                    Details = "A cosmopolitan island with top-notch facilities.",
                    Rate = 8000.00,
                    Sqft = 6000,
                    Occupancy = 18,
                    ImageUrl = "https://example.com/victoria.jpg",
                    Amenity = "Business hubs, High-end hotels, Waterfronts",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
