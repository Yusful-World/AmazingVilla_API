using AmazingVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazingVilla_API.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
