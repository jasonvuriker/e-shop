using e_shop.Application;
using e_shop.Application.Services;
using e_shop.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers();

builder.Services.AddScoped<OrderService>();
builder.Services.AddDbContext<ShopContext>(options =>
{
    var connectionString = "Server=localhost;Port=5432;Database=eCommerce;User Id=postgres;Password=postgres;";

    options.UseNpgsql(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .UseSnakeCaseNamingConvention()
        .AddInterceptors(new AuditInterceptor());
});

builder.Services.AddSwaggerGen();

builder.Services.AddApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
