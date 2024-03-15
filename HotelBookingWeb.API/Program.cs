using HotelBooking.Data.Abstract;
using HotelBooking.Data.Concrete;
using HotelBooking.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddDbContext<HotelDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

    options.UseSqlServer(connectionString);
});

builder.Services.AddTransient<IHotelRepository, EFHotelRepository>(provider =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

    return new EFHotelRepository(provider.GetRequiredService<HotelDbContext>());
});
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
