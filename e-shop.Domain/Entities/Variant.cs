using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Variant
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string VariantOption { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    public Guid VariantOptionId { get; set; }

    [ForeignKey("VariantOptionId")]
    public VariantOption VariantOptionEntity { get; set; }
}