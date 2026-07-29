using VoyageAI.Application.Interfaces;
using VoyageAI.Application.Services;
using VoyageAI.Infrastructure.AI;
using VoyageAI.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddScoped<ITravelPlannerService, TravelPlannerService>();
builder.Services.AddScoped<ITravelPlannerService, TravelPlannerService>();

builder.Services.AddScoped<IAIService, GeminiAiService>();
builder.Services.Configure<GeminiOptions>(
    builder.Configuration.GetSection("Gemini"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();