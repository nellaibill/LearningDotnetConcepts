


using DesignPatterns;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Factory;
using DesignPatterns.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMessageService,GmailService>();
builder.Services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout
    options.Cookie.HttpOnly = true; // Make the session cookie accessible only by the server
    options.Cookie.IsEssential = true; // Make the session cookie essential
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<CustomMiddleware>();
app.UseResponseCaching();
app.UseSession();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
/*
MealBuilder mealBuilder = new MealBuilder();
mealBuilder.BuildMainCourse("Briyani");
mealBuilder.BuildSideDish("Chicken 65");
mealBuilder.BuildDrink("Pepsi");
Console.WriteLine(mealBuilder.Build());

LegacyPrinter legacyPrinter = new LegacyPrinter();
legacyPrinter.print("From Legacy");
IModernPrinter modernPrinter = new PrinterAdapter(legacyPrinter);
modernPrinter.print("From Printer Adapter");


*/

Singleton singleton = Singleton.Instance();
Singleton singleton1 = Singleton.Instance();

if(singleton == singleton1)
{
    Console.WriteLine("These objects are same");
}

var factory = new UserFactory();
IUser doctor = factory.GetUser("doctor");
doctor.ShowDetails();
IUser nurse = factory.GetUser("nurse");
nurse.ShowDetails();
if (doctor == nurse)
{
    Console.WriteLine("These objects are same");
}
else
{
    Console.WriteLine("different");
}

Console.ReadLine();

