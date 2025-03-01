using e_shop.Domain.Entities;

namespace e_shop.Application.Dtos;

public class CreateProductRequestDto
{
    public string SKU { get; set; }

    public string ProductName { get; set; }

    public decimal RegularPrice { get; set; }

    public decimal DiscountPrice { get; set; }

    public int Quantity { get; set; }

    public string ProductDescription { get; set; }

    public decimal ProductWeight { get; set; }

    public string ProductNote { get; set; }

    public bool Published { get; set; }
}