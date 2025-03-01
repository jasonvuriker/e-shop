using e_shop.Application.Dtos;
using e_shop.DataAccess;
using FluentValidation;

namespace e_shop.Application.Validators;

public class CreateOrderRequestDtoValidator : AbstractValidator<CreateOrderRequestDto>
{
    public CreateOrderRequestDtoValidator()
    {
        RuleFor(r => r.CustomerId)
            .NotEmpty()
            .Custom(ValidateCustomer);

        var orderItemValidator = new CreateOrderItemRequestDtoValidator();

        RuleFor(r => r.OrderItems)
            .NotEmpty()
            .ForEach(r => r.NotNull())
            .ForEach(r => r.SetValidator(orderItemValidator));

        RuleForEach(r => r.OrderItems)
            .ChildRules(r =>
                r.RuleFor(w => w.Price)
                    .GreaterThanOrEqualTo(0));
    }

    private void ValidateCustomer(int customerId, ValidationContext<CreateOrderRequestDto> context)
    {
        using var dbContext = new ShopContext();

        var isCustomerExists = dbContext.Customers.Any(r => r.Id == customerId);

        if (!isCustomerExists)
        {
            context.AddFailure($"No customer found for CustomerId: {customerId}");
        }
    }
}