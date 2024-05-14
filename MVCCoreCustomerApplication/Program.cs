using MVCCoreCustomerApplication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
/*
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/
app.Map("/Home", Execute);
app.MapWhen(context => { return context.Request.Query.ContainsKey("Search"); }, MapWhenExecuteQueryParam);
app.UseLogic1Middleware();
app.UseLogic2Middleware();
app.UseLogic3Middleware();

void Execute(IApplicationBuilder appBuilder)
{
    appBuilder.UseLogic3Middleware();
}
void MapWhenExecuteQueryParam(IApplicationBuilder appBuilder)
{
    appBuilder.UseLogic2Middleware();
}

app.Run();