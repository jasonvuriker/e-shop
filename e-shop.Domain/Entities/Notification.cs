using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Notification
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid? AccountId { get; set; }

    [ForeignKey("AccountId")]
    public StaffAccount Account { get; set; }

    [MaxLength(100)]
    public string Title { get; set; }

    public string Content { get; set; }

    public bool? Seen { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ReceiveTime { get; set; }

    public DateTime? NotificationExpiryDate { get; set; }
}