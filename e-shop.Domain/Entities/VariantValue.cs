using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class VariantValue
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public Guid VariantId { get; set; }

    [ForeignKey("VariantId")]
    public Variant Variant { get; set; }

    [Required]
    public Guid ProductAttributeValueId { get; set; }

    [ForeignKey("ProductAttributeValueId")]
    public ProductAttributeValue ProductAttributeValue { get; set; }
}