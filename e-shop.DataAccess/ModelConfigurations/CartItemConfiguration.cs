using eShopNew.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfigurations;

public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.HasKey(r => r.Id);

        builder.HasOne(r => r.Product)
            .WithMany()
            .HasForeignKey(r => r.ProductId);

        builder.HasOne(r => r.Cart)
            .WithMany(r => r.CardItems);

        builder.Property(r => r.Quantity)
            .HasDefaultValue(1)
            .IsRequired();
    }
}