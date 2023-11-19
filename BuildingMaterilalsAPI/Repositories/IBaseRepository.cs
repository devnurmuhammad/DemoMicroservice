namespace BuildingMaterials.Domain.Interfaces;

public interface IBaseRepository<TModel> where TModel : class
{
    public ValueTask<bool> CreateAsync(TModel model);
    public ValueTask<bool> UpdateAsync(string name, TModel model);
    public ValueTask<bool> DeleteAsync(string name);
    public ValueTask<IList<TModel>> GetAllAsync();
    public ValueTask<TModel> GetByNameAsync(string name);
    public ValueTask<int> GetCountAsync();
}
