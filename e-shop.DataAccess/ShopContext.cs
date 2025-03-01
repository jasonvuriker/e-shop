using e_shop.DataAccess.ModelConfigurations;
using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Customers;
using eShopNew.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<CartItem> CartItems { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderItem> OrderItems { get; set; }

    public ShopContext(DbContextOptions options)
        : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly);

        modelBuilder.Entity<Order>(builder =>
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.OrderApprovedAt)
                .IsRequired(false);

            builder.Property(r => r.OrderDeliveredCarrierDate)
                .IsRequired(false);

            builder.Property(r => r.OrderDeliveredCustomerDate)
                .IsRequired(false);

            builder.HasOne(r => r.Coupon)
                .WithMany(r => r.Orders)
                .IsRequired(false);

            builder.HasOne(r => r.Customer)
                .WithMany(r => r.Orders);

            builder.HasOne(r => r.OrderStatus)
                .WithMany();
        });

        modelBuilder.Entity<OrderItem>(builder =>
        {
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Order)
                .WithMany(r => r.OrderItems);

            builder.HasOne(r => r.Product)
                .WithMany();

            builder.Property(r => r.Price);

            builder.Property(r => r.Quantity);
        });
    }
}