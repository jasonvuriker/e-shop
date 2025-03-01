using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ShippingCountryZone
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public int ShippingZoneId { get; set; }

    [ForeignKey("ShippingZoneId")]
    public ShippingZone ShippingZone { get; set; }

    [Required]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    public Country Country { get; set; }
}