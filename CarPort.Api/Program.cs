using CarPort.Api.Data;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var logger = NLog.LogManager
    .Setup()
    .LoadConfigurationFromFile("nlog.config")
    .GetCurrentClassLogger();
    
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


builder.Logging.ClearProviders();
builder.Host.UseNLog();

app.UseHttpsRedirection();

// Controllers mapping
app.MapControllers();

app.Run();