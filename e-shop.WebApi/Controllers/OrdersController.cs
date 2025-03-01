using e_shop.Application.Dtos;
using e_shop.Application.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder(
            [FromBody] CreateOrderRequestDto orderDto)
        {
            var validator = new CreateOrderRequestDtoValidator();

            var validationResult = await validator.ValidateAsync(orderDto);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok();
        }
    }
}
