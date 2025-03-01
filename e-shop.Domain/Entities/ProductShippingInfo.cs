using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ProductShippingInfo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid? ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    public decimal Weight { get; set; } = 0;

    [MaxLength(10)]
    public string WeightUnit { get; set; }

    public decimal Volume { get; set; } = 0;

    [MaxLength(10)]
    public string VolumeUnit { get; set; }

    public decimal DimensionWidth { get; set; } = 0;

    public decimal DimensionHeight { get; set; } = 0;

    public decimal DimensionDepth { get; set; } = 0;

    [MaxLength(10)]
    public string DimensionUnit { get; set; }
}