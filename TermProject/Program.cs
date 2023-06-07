using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
//    option =>
//    {
//        option.LoginPath= "/Access/Login";
//    });

builder.Services.AddDbContext<AppDbContext>(
    option =>
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
    }
    );

var app = builder.Build();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
SeedData.SeedDatabase(context);

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
