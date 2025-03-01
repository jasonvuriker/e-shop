using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class StaffAccount
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public int? RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; }

    [Required, MaxLength(100)]
    public string FirstName { get; set; }

    [Required, MaxLength(100)]
    public string LastName { get; set; }

    [MaxLength(100)]
    public string PhoneNumber { get; set; }

    [Required, MaxLength(255)]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public bool Active { get; set; } = true;

    public string Image { get; set; }

    public string Placeholder { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public StaffAccount UpdatedByAccount { get; set; }
}