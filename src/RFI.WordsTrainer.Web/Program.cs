using RFI.WordsTrainer.Infrastructure;
using RFI.WordsTrainer.Infrastructure.Data.EF;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddRazorPages();  // Because of RazorPages

builder.AddInfrastructureServices();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    await app.InitialiseDatabaseAsync();
}
else
{   // Because of RazorPages
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting(); // Because of RazorPages

app.UseAuthorization();

app.MapControllers();

app.MapDefaultEndpoints(); // Aspire health checks and metrics

// Because of RazorPages
app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();


// TODO - Add Swagger (into method AddServiceDefaults)
// TODO - Add Swagger documentation to controller
// TODO - add problemdetails
// TODO - add global error handling
// TODO - add favicon