//Add using for entityFrameworkCore and entityFrameworkCore.InMemory
using Microsoft.EntityFrameworkCore;
using Entity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add DBContext using in memory database
builder.Services.AddDbContext<RentCarDbContext>(options => options.UseInMemoryDatabase("RentCar"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
