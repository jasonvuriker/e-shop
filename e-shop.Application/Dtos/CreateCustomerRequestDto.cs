namespace e_shop.Application.Dtos;

public class CreateCustomerRequestDto
{
    public int Id { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string PhoneNumber { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }
}