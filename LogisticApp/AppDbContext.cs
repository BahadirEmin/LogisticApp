using LogisticApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Truck> Trucks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=trucks.db");
            }
        }
    }
}