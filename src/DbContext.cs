using Habitr.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Habitr.src.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GeoLocation> GeoLocations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Remark> Remarks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activity>()
                .HasMany(a => a.Remarks)
                .WithOne(r => r.Activity)
                .HasForeignKey(r => r.ActivityId);
        }        
    }
}
