using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using RentABookManagementAPI_Reopsitary.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RentABookManagementAPIDbContext>(cnn => cnn.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnect")));

builder.Services.AddScoped<IBook, BookRepos>();
builder.Services.AddScoped<ICustomer, CustomerRepos>();
builder.Services.AddScoped<IEmployee, EmployeeRepos>();
builder.Services.AddScoped<IReservation, ReservationRepos>();
builder.Services.AddScoped<IReservationItem, ReservationItemRepos>();

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
