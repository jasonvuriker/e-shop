namespace e_shop.DataAccess.Services;

public class OrderService
{
    private readonly ShopContext _context;

    public OrderService(ShopContext context)
    {
        _context = context;
    }

}