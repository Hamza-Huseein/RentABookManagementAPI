using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using RentABookManagementAPI_Reopsitary.Repos;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Rent A Book Management API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Hamza Hussein",
            Email = "Hamza.hussein2000@outlook.com",
        }
    });
    //enable comments
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
}); builder.Services.AddDbContext<RentABookManagementAPIDbContext>(cnn => cnn.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnect")));

builder.Services.AddScoped<IBook, BookRepos>();
builder.Services.AddScoped<ICustomer, CustomerRepos>();
builder.Services.AddScoped<IEmployee, EmployeeRepos>();
builder.Services.AddScoped<IReservation, ReservationRepos>();
builder.Services.AddScoped<IReservationItem, ReservationItemRepos>();

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
Serilog.Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).
                WriteTo.File(configuration.GetValue<string>("LoggerFilePath")
                , rollingInterval: RollingInterval.Day).MinimumLevel.Debug().
                CreateLogger();
Serilog.Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).
                WriteTo.File(configuration.GetValue<string>("LoggerErrorFilePath")
                , rollingInterval: RollingInterval.Day).MinimumLevel.Error().
                CreateLogger();
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

try
{
    Log.Information("Starting web host");
    //CreateHostBuilder(args).Build().Run();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}