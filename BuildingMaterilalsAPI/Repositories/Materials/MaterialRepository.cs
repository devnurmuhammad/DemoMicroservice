using BuildingMaterials.DataAccess.DataAccess;
using BuildingMaterials.Domain.Entities;
using BuildingMaterilals.Web.DTOs;
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

        public async ValueTask<bool> CreateAsync(MaterialDTO materialDTO)
        {
            Material material = new Material();
            material.Name = materialDTO.Name;
            material.Description = materialDTO.Description;
            material.Cost = materialDTO.Cost;

            var result = await dbContext.AddAsync(material);
            await dbContext.SaveChangesAsync();

            if (result != null)
            {
                return true;
            }
            return false;
        }



        public async ValueTask<bool> DeleteAsync(string name)
        {
            var result = await dbContext.Materials.FirstOrDefaultAsync(x => x.Name == name);
            if (result != null)
            {
                dbContext.Remove(result);
                await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async ValueTask<IList<Material>> GetAllAsync()
        {
            IList<Material> result = await dbContext.Materials.ToListAsync();
            return result;
        }

        public async ValueTask<Material> GetByNameAsync(string name)
        {
            Material? result = await dbContext.Materials.FirstOrDefaultAsync(x => x.Name == name);
            return result != null ? result : new Material();
        }

        public async ValueTask<int> GetCountAsync()
        {
            var result = await dbContext.Materials.CountAsync();
            return result;
        }

        public async ValueTask<bool> UpdateAsync(string name, MaterialDTO modelDTO)
        {
            var result = await dbContext.Materials.FirstOrDefaultAsync(x => x.Name == name);
            if (result != null)
            {
                //result.Name = modelDTO.Name;
                //result.Description = modelDTO.Description;
                result.Cost = modelDTO.Cost;
                await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
