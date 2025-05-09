
using Microsoft.EntityFrameworkCore;
using MiniSiparisTakipUygulamasi.Models.MyConext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

//view sayfalarýna gitmek için yazýcaðýmýz route url 
app.MapControllerRoute(
    name: "ProductDetail",
    pattern: "{controller=Product}/{action=Details}/{id?}");

app.MapControllerRoute(
    name: "ProductIndex",
    pattern: "{controller=Product}/{action=Index}");

app.Run();
