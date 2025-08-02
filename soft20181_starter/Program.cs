using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Default"); /*?? throw new InvalidOperationException("Connection string 'EventAppDbContextConnection' not found.");*/

// Add services to the container.
builder.Services.AddRazorPages();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<EventAppDbContext>(options =>
 options.UseSqlite(Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<AppUser, IdentityRole>()
.AddDefaultTokenProviders()
.AddDefaultUI()
.AddEntityFrameworkStores<EventAppDbContext>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
