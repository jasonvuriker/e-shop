using e_shop.Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using e_shop.Domain.Entities;

namespace eShopNew.Entities;

public class Cart : IAuditable
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual ICollection<CartItem> CardItems { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
}