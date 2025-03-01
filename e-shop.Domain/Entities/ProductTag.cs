using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ProductTag
{
    [Key]
    public Guid TagId { get; set; }

    [ForeignKey("TagId")]
    public Tag Tag { get; set; }

    [Key]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}