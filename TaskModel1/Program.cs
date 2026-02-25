using TaskModel1.Interfaces;
using TaskModel1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers(); // Enables your controllers

// Register your two services
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IFoodService, FoodService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map the routes for your custom controllers
app.MapControllers(); 

app.Run();