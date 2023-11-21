using BuildingMaterilals.Web.DTOs;

namespace BuildingMaterials.Domain.Interfaces;

public interface IBaseRepository<TModel> where TModel : class
{
    public ValueTask<bool> CreateAsync(MaterialDTO materialDTO);
    public ValueTask<bool> UpdateAsync(string name, MaterialDTO materialDTO);
    public ValueTask<bool> DeleteAsync(string name);
    public ValueTask<IList<TModel>> GetAllAsync();
    public ValueTask<TModel> GetByNameAsync(string name);
    public ValueTask<int> GetCountAsync();
}
