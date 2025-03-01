using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class VariantOption
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Title { get; set; }

    public Guid? ImageId { get; set; }

    [ForeignKey("ImageId")]
    public Gallery Image { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    public decimal SalePrice { get; set; } = 0;

    public decimal ComparePrice { get; set; } = 0;

    public decimal? BuyingPrice { get; set; }

    public int Quantity { get; set; } = 0;

    public string SKU { get; set; }

    public bool Active { get; set; } = true;
}