using System.ComponentModel.DataAnnotations;

namespace e_shop.Application.Dtos;

public class CreateOrderRequestDto
{
    [Required]
    public int CustomerId { get; set; }

    public List<CreateOrderItemRequestDto> OrderItems { get; set; }
}