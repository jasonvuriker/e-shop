using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class OrderItem
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public Product Product { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}