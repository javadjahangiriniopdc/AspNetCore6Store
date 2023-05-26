using AspNetCore6Store.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var CnnString = builder.Configuration.GetConnectionString("DefaultConection");
builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(CnnString));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStatusCodePages();

app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();



app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("pagination", "{controller=Home}/{action=Index}/{category}/Page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "{controller=Home}/{action=Index}/Page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "{controller=Home}/{action=Index}/{category}");

    endpoints.MapDefaultControllerRoute();
}


);

app.Run();
