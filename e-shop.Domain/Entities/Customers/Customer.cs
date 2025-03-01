using System.ComponentModel.DataAnnotations;
using eShopNew.Entities;

namespace e_shop.Domain.Entities.Customers;

public class Customer : IAuditable
{
    public Customer()
    {
        Orders = new List<Order>();
        CustomerAddresses = new List<CustomerAddress>();
    }

    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string FirstName { get; set; }

    [Required, MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string? PasswordHash { get; set; }

    public bool Active { get; set; } = true;

    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}