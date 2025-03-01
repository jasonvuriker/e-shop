using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ShippingZone
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    [Required, MaxLength(255)]
    public string DisplayName { get; set; }

    public bool Active { get; set; } = false;

    public bool FreeShipping { get; set; } = false;

    [MaxLength(64)]
    public string RateType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public StaffAccount UpdatedByAccount { get; set; }
}