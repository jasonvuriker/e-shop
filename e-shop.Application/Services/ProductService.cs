using e_shop.DataAccess;
using e_shop.Domain.Entities;

namespace e_shop.Application.Services;

public class ProductService
{
    private readonly ShopContext _context;

    public CartService CartService { get; }

    public ProductService(ShopContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products;
    }

    public async Task<Product> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
    }

    public void CreateProductsWithCategories()
    {
        //var category = _context.Categories.First();

        //category.Active = false;

        var existingProduct = _context.Products.FirstOrDefault();

        var category = new Category()
        {
            Active = true,
            CategoryDescription = " ",
            CategoryName = "Category 1",
            Icon = " ",
            ImagePath = " ",
            Products = new List<Product>() { new Product
            {
                ProductName = "Product 1",
                RegularPrice = 100,
                SKU = "SKU-1",
                DiscountPrice = 1,
                ProductWeight = 1,
                ProductDescription = " ",
                ProductNote = " ",
                Published = true,
                Quantity = 1,
            },
                existingProduct }
        };

        _context.Categories.Add(category);

        _context.SaveChanges();
    }

    public int SaveChanges() => _context.SaveChanges();
}