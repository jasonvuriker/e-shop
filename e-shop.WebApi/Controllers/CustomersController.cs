using e_shop.Application.Dtos;
using e_shop.DataAccess;
using e_shop.Domain.Entities.Customers;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using e_shop.Application.Validators;

namespace e_shop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ShopContext _context;

    public CustomersController(ShopContext context)
    {
        _context = context;
    }

    [HttpGet("all-customers")]
    public IActionResult GetAllCustomers()
    {
        var customers = _context
            .Customers
            .Select(r => new CreateCustomerRequestDto()
            {
                Id = r.Id,
                Firstname = r.FirstName,
                Lastname = r.LastName,
                PhoneNumber = r.PhoneNumber,
                Password = Encoding.UTF8.GetString(Convert.FromBase64String(r.PasswordHash)),
            })
            .ToList();

        return Ok(customers);
    }

    [HttpPost("add-customer")]
    public async Task<IActionResult> AddCustomer([FromBody] CreateCustomerRequestDto customerDto)
    {
        var validator = new CreateCustomerRequestDtoValidator();
        var validationResult = await validator.ValidateAsync(customerDto);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        var customer = new Customer()
        {
            FirstName = customerDto.Firstname,
            LastName = customerDto.Lastname,
            PhoneNumber = customerDto.PhoneNumber,
            PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(customerDto.Password)),
            Active = true,
        };

        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
        return Ok(customer);
    }

    [HttpDelete("remove-customer")]
    public async Task<IActionResult> RemoveCustomer([FromQuery] int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
        {
            return NotFound();
        }
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return Ok();
    }
}