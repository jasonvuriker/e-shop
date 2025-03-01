using e_shop.Domain.Entities;

public class Product : IAuditable
{
    public Product()
    {
        Categories = new List<Category>();
    }
    public int Id { get; set; }
    public string SKU { get; set; }
    public string ProductName { get; set; }
    public decimal RegularPrice { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Quantity { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductWeight { get; set; }
    public string ProductNote { get; set; }
    public bool Published { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public int CreatedBy { get; set; } = 1;
    public int? UpdatedBy { get; set; }

    public virtual ICollection<Category> Categories { get; set; }
}