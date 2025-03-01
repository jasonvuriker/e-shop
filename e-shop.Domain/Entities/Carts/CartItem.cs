using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using e_shop.Domain.Entities;

namespace eShopNew.Entities;

public class CartItem : IAuditable
{
    public int Id { get; set; }

    public int? CartId { get; set; }

    public virtual Cart Cart { get; set; }

    public int? ProductId { get; set; }

    public virtual Product Product { get; set; }

    public int Quantity { get; set; } = 1;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
}