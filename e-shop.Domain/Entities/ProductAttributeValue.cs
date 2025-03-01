using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ProductAttributeValue
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public Guid ProductAttributeId { get; set; }

    [ForeignKey("ProductAttributeId")]
    public ProductAttribute ProductAttribute { get; set; }

    [Required]
    public Guid AttributeValueId { get; set; }

    [ForeignKey("AttributeValueId")]
    public AttributeValue AttributeValue { get; set; }
}