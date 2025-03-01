using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class AttributeValue
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public Guid AttributeId { get; set; }

    [ForeignKey("AttributeId")]
    public Attribute Attribute { get; set; }

    [Required, MaxLength(255)]
    public string AttributeValueName { get; set; }

    [MaxLength(50)]
    public string Color { get; set; }
}