using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Coupon
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, MaxLength(50)]
    public string Code { get; set; }

    public decimal? DiscountValue { get; set; }

    [Required, MaxLength(50)]
    public string DiscountType { get; set; }

    public decimal TimesUsed { get; set; } = 0;

    public decimal? MaxUsage { get; set; }

    public decimal? OrderAmountLimit { get; set; }

    public DateTime? CouponStartDate { get; set; }

    public DateTime? CouponEndDate { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public virtual StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public virtual StaffAccount UpdatedByAccount { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}