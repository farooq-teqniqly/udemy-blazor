using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;

namespace YumBlazor.Services;

public sealed class CategoryService : ICategoryService
{
  private readonly ApplicationDbContext _dbContext;

  public CategoryService(ApplicationDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task<Category> CreateCategoryAsync(Category category)
  {
    _dbContext.Categories.Add(category);
    await _dbContext.SaveChangesAsync();
    return category;
  }

  public async Task<bool> DeleteCategoryAsync(int id)
  {
    var category = await _dbContext.FindAsync<Category>(id);

    if (category is null)
    {
      return false;
    }

    _dbContext.Categories.Remove(category);
    var numDeleted = await _dbContext.SaveChangesAsync();
    return numDeleted > 0;
  }

  public async Task<IReadOnlyCollection<Category>> GetAllAsync() =>
    await _dbContext.Categories.ToListAsync();

  public async Task<Category?> GetCategoryAsync(int id) => await _dbContext.FindAsync<Category>(id);

  public async Task<Category?> UpdateCategoryAsync(Category category)
  {
    var dbCategory = await GetCategoryAsync(category.Id);

    if (dbCategory is null)
    {
      return null;
    }

    dbCategory.Name = category.Name;
    await _dbContext.SaveChangesAsync();
    return dbCategory;
  }
}
