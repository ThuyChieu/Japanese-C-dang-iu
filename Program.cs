using Microsoft.EntityFrameworkCore;
using Japanese_C_dang_iu.Models;
using Japanese_C_dang_iu.Services;

var builder = WebApplication.CreateBuilder(args);
var Services = builder.Services;

// Add SQL Server
Services.AddDbContext<DataContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Add custom services
Services.AddScoped<IUserService, UserService>();

// Add services to the container.
Services.AddControllersWithViews();

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
