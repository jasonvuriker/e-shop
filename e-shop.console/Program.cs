

using e_shop.DataAccess;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using var context = new ShopContext();

//var products = context.Products.ToList();

var product = new Product
{
    ProductName = "Product 1112",
    RegularPrice = 100,
    SKU = "SKU-1",
    DiscountPrice = 1,
    ProductWeight = 1,
    ProductDescription = " ",
    ProductNote = " ",
    Published = true,
    Quantity = 1,
    Categories = new List<Category>()
    {
        new Category()
    }
};

context.Update(product);

Console.WriteLine(context.ChangeTracker.DebugView.LongView);

context.ChangeTracker.Clear();

Console.WriteLine(context.ChangeTracker.DebugView.LongView);

context.SaveChanges();

//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//context.Attach(product);

//product.DiscountPrice = 3;

//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//context.SaveChanges();

//Console.WriteLine(context.ChangeTracker.DebugView.LongView);


Console.ReadLine();