using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Supplier
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, MaxLength(255)]
    public string SupplierName { get; set; }

    [MaxLength(255)]
    public string Company { get; set; }

    [MaxLength(255)]
    public string PhoneNumber { get; set; }

    [Required]
    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    [Required]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    public Country Country { get; set; }

    [MaxLength(255)]
    public string City { get; set; }

    public string Note { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public StaffAccount UpdatedByAccount { get; set; }
}