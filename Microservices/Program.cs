using Microservices;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});
// Add antiforgery services
builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-CSRF-TOKEN"; // Optional: Change the header name
});
// Add Application Insights telemetry
builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["ApplicationInsights:InstrumentationKey"]);

// Configure logging
builder.Logging.AddApplicationInsights();
builder.Services.AddApiVersioning(config =>
{
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.ReportApiVersions = true;
    config.ApiVersionReader = new HeaderApiVersionReader("api-version");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
          .AddCheck<MyCustomHealthCheck>("my_health_check");
builder.Services.AddTransient<MyMicroservice>();
builder.Services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout
    options.Cookie.HttpOnly = true; // Make the session cookie accessible only by the server
    options.Cookie.IsEssential = true; // Make the session cookie essential
});
var app = builder.Build();
app.UseMiddleware<CustomExceptionMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHealthChecks("/health");
app.UseResponseCaching();
app.UseSession();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
