using e_shop.Application.Dtos;
using e_shop.Application.Services;
using e_shop.Application.Validators;
using e_shop.DataAccess;
using eShopNew.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder(
            [FromBody] CreateOrderRequestDto orderDto)
        {
            //var validator = new CreateOrderRequestDtoValidator();

            //var validationResult = await validator.ValidateAsync(orderDto);

            //if (!validationResult.IsValid)
            //{
            //    return BadRequest(validationResult.Errors);
            //}

            return Ok();
        }
    }
}
