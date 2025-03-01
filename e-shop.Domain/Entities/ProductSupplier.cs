using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class ProductSupplier
{
    [Key]
    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Key]
    public Guid SupplierId { get; set; }

    [ForeignKey("SupplierId")]
    public Supplier Supplier { get; set; }
}
