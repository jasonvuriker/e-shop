using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Application.Dtos;
using FluentValidation;

namespace e_shop.Application.Validators;

public class CreateProductRequestDtoValidator : AbstractValidator<CreateProductRequestDto>
{
    public CreateProductRequestDtoValidator()
    {
        RuleFor(r => r.SKU)
            .NotEmpty()
            .Length(16);

        RuleFor(r => r.ProductName)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(r => r.Quantity)
            .GreaterThanOrEqualTo(0);

        RuleFor(r => r.ProductDescription)
            .MaximumLength(255);

        RuleFor(r => r.ProductNote)
            .MaximumLength(255);

        RuleFor(r => r.RegularPrice)
            .NotEmpty()
            .GreaterThan(0)
            .When(r => r.Published);

        RuleFor(r => r.DiscountPrice)
            .NotEmpty()
            .LessThanOrEqualTo(r => r.RegularPrice)
            .When(r => r.Published);

        When(r => r.Published, () =>
        {
            RuleFor(r => r.RegularPrice)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(r => r.DiscountPrice)
                .NotEmpty()
                .LessThanOrEqualTo(r => r.RegularPrice);
        });
    }
}