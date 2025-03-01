using e_shop.Domain.Entities;

namespace e_shop.DataAccess.Services;

public class CategoryService
{
    private readonly ShopContext _context;

    public CategoryService(ShopContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> GetAll()
    {
        return _context.Categories;
    }

    public async Task<Category> GetById(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public void Add(Category product)
    {
        _context.Categories.Add(product);
    }

    public int SaveChanges() => _context.SaveChanges();
}
