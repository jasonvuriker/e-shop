using eShopNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess.Services;

public interface ICartService
{
    Task AddCart(Cart cart);
    Task AddCartItem(CartItem cart);
    void DeleteCart(Cart cart);
    void UpdateCart(Cart cart);
    Task<int> SaveChanges();
}

public class CartService : ICartService
{
    private readonly ShopContext _context;

    public CartService(ShopContext context)
    {
        _context = context;
    }

    public async Task AddCart(Cart cart)
    {
        await _context.Carts.AddAsync(cart);
    }

    public async Task AddCartItem(CartItem cart)
    {
        await _context.CartItems.AddAsync(cart);
    }

    public void DeleteCart(Cart cart)
    {
        _context.Carts.Remove(cart);
    }

    public void UpdateCart(Cart cart)
    {
        _context.Carts.Update(cart);
    }

    //public IEnumerable<Cart> GetCarts()
    //{
    //    return _context.Carts.Include(r=>r.)
    //}

    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }
}