using BuildingMaterials;
using BuildingMaterials.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterilals.Web.Repositories.Materials
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly ApplicationDbContext dbContext;
        public MaterialRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async ValueTask<bool> CreateAsync(Material model)
        {
            Material material = new Material();
            material.Name = model.Name;
            material.Description = model.Description;
            material.Cost = model.Cost;

            var result = await dbContext.AddAsync(material);
            await dbContext.SaveChangesAsync();

            if (result != null)
            {
                return true;
            }
            return false;
        }

        public ValueTask<bool> DeleteAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IList<Material>> GetAllAsync()
        {
            IList<Material> result = await dbContext.Materials.ToListAsync();
            return result;
        }

        public ValueTask<Material> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(string name, Material model)
        {
            throw new NotImplementedException();
        }
    }
}
