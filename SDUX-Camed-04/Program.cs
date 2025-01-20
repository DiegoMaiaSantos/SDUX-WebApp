using Microsoft.EntityFrameworkCore;
using SDUX_Camed_04.Data;

var builder = WebApplication.CreateBuilder(args);

// Add dbcontext to the dbo
builder.Services.AddDbContext<CamedDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CamedConnection")));

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
