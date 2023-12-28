using Project.Core.Repositories;
using Project.Core.Services;
using Project.Data;
using Project.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOrderServices, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRiposetory>();
builder.Services.AddScoped<ICustomerServices, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerReposetory>();
builder.Services.AddScoped<IProductServices, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductReposetory>();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
