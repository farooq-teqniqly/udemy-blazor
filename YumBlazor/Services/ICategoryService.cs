using YumBlazor.Data;

namespace YumBlazor.Services
{
  public interface ICategoryService
  {
    public Task<Category> CreateCategoryAsync(Category category);
    public Task<bool> DeleteCategoryAsync(int id);
    public Task<IReadOnlyCollection<Category>> GetAllAsync();
    public Task<Category?> GetCategoryAsync(int id);
    public Task<Category?> UpdateCategoryAsync(Category category);
  }
}
