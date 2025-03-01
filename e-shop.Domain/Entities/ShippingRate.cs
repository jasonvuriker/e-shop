using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ShippingRate
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public int ShippingZoneId { get; set; }

    [ForeignKey("ShippingZoneId")]
    public ShippingZone ShippingZone { get; set; }

    [MaxLength(10)]
    public string WeightUnit { get; set; }

    public decimal MinValue { get; set; } = 0;

    public decimal? MaxValue { get; set; }

    public bool NoMax { get; set; } = true;

    public decimal Price { get; set; } = 0;
}