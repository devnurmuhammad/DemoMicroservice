using Microsoft.EntityFrameworkCore;

namespace BuildingMaterials.DataAccess.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
