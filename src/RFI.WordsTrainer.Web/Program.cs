using RFI.WordsTrainer.Infrastructure;
using RFI.WordsTrainer.Infrastructure.Data.EF;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.AddInfrastructureServices();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    await app.InitialiseDatabaseAsync();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapDefaultEndpoints(); // Aspire health checks and metrics

app.Run();


// TODO - Add Swagger (into method AddServiceDefaults)
// TODO - Add Swagger documentation to controller
// TODO - add problemdetails
// TODO - add global error handling