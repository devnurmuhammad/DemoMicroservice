using Microsoft.EntityFrameworkCore;

namespace BuildingMaterials.DataAccess.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
