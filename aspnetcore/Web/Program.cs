using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using NSwag;
using Web.Abstractions;
using Web.services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Host=database;Port=5432;Database=postgres;Username=user;Password=asd389ins324mndsl83nd56lasjkfd";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


builder.Services.AddControllers();
builder.Services.AddScoped<IListingService, ListingService>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate(); // luo DB + taulut + ajaa migrations
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseOpenApi();
app.MapControllers();
app.Run();
