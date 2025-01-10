using AppDataRepositoryEF.CW19.Users;
using AppDomainAppService.CW19.Users;
using AppDomainCore.CW19.Users.Contract.AppService;
using AppDomainCore.CW19.Users.Contract.Repository;
using AppDomainCore.CW19.Users.Contract.Service;
using DomainService.Users;
using Microsoft.EntityFrameworkCore;
using AppDataRepositoryEF.CW19.Db;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json")
.Build();

var ConnectionString = builder.Configuration.GetConnectionString("sql");
builder.Services.AddDbContext<AppDbContext>(option =>option.UseSqlServer(ConnectionString));



builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserAppService,UserAppService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
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
