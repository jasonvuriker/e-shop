using e_shop.DataAccess;
using eShopNew.Entities;

namespace e_shop.Application.Services;

public class OrderService
{
    private readonly ShopContext _context;

    public OrderService(ShopContext context)
    {
        _context = context;
    }

    public async Task AddOrder(Order order)
    {
        await _context.Orders.AddAsync(order);
    }
}