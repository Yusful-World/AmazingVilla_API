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
    }
}
