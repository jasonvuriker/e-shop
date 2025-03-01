using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Gallery
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid? ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    public string Image { get; set; }

    [Required]
    public string Placeholder { get; set; }

    public bool IsThumbnail { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}