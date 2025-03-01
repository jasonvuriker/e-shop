using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class OrderStatus
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, MaxLength(255)]
    public string StatusName { get; set; }

    [Required, MaxLength(50)]
    public string Color { get; set; }

    [MaxLength(10)]
    public string Privacy { get; set; } = "private";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public StaffAccount UpdatedByAccount { get; set; }
}