using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using NSwag;
using Web.Abstractions;
using Web.services;

var builder = WebApplication.CreateBuilder(args);
Env.Load();

var connectionString = @"Host=" + Environment.GetEnvironmentVariable("POSTGRES_HOST") + ";Username=" + Environment.GetEnvironmentVariable("POSTGRES_USER") + ";Password=" + Environment.GetEnvironmentVariable("POSTGRES_PASSWORD") + ";Database=" + Environment.GetEnvironmentVariable("POSTGRES_DB");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


builder.Services.AddControllers();
builder.Services.AddScoped<IListingService, ListingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseOpenApi();
app.MapControllers();
app.Run();
