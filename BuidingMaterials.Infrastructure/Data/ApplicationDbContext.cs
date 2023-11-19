using BuildingMaterials.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterials
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>()
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
