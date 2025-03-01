using eShopNew.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfigurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(r => r.Id);

        builder.HasMany(r => r.CardItems)
            .WithOne(r => r.Cart)
            .HasForeignKey(r => r.CartId);
    }
}