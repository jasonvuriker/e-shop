using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopNew.Entities;

public class Slideshow
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [MaxLength(80)]
    public string Title { get; set; }

    public string DestinationUrl { get; set; }

    [Required]
    public string Image { get; set; }

    [Required]
    public string Placeholder { get; set; }

    [MaxLength(160)]
    public string Description { get; set; }

    [MaxLength(50)]
    public string BtnLabel { get; set; }

    public int DisplayOrder { get; set; }

    public bool Published { get; set; } = false;

    public int Clicks { get; set; } = 0;

    public string Styles { get; set; }  // JSONB mapping can be done via string serialization.

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    public StaffAccount CreatedByAccount { get; set; }

    [ForeignKey("UpdatedBy")]
    public StaffAccount UpdatedByAccount { get; set; }
}