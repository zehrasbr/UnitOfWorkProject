using Microsoft.EntityFrameworkCore;
using UnitOfWork.BusinessLayer.Abstract;
using UnitOfWork.BusinessLayer.Concrete;
using UnitOfWork.DataAccessLayer.Abstract;
using UnitOfWork.DataAccessLayer.Concrete;
using UnitOfWork.DataAccessLayer.EntityFramework;
using UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICustomerProcessDal, EfCustomerProcessDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();

builder.Services.AddScoped<ICustomerProcessDal, EfCustomerProcessDal>();
builder.Services.AddScoped<ICustomerProcessService, CustomerProcessManager>();

builder.Services.AddScoped<IUowDal, IUowDal>();

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
