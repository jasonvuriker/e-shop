using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Application.Dtos;
using FluentValidation;

namespace e_shop.Application.Validators;

public class CreateOrderItemRequestDtoValidator : AbstractValidator<CreateOrderItemRequestDto>
{
    public CreateOrderItemRequestDtoValidator()
    {
        RuleFor(r => r.ProductId)
            .NotEmpty();

        RuleFor(r => r.Quantity)
            .NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(r => r.Price)
            .NotEmpty();
    }
}