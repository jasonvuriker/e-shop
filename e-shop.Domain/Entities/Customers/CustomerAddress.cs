using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Customers;

public class CustomerAddress : IAuditable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; }

    [Required]
    public string AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    [Required, MaxLength(255)]
    public string PhoneNumber { get; set; }

    [Required, MaxLength(100)]
    public string DialCode { get; set; }

    [Required, MaxLength(255)]
    public string Country { get; set; }

    [Required, MaxLength(255)]
    public string PostalCode { get; set; }

    [Required, MaxLength(255)]
    public string City { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
}