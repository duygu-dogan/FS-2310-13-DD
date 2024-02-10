using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<MiniShopDbContext>()
    .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola Ayarları
    options.Password.RequiredLength = 6; //Password should contain at least 6 characters. Default value is also 6.
    options.Password.RequireDigit = true; // Password should contain at least 1 digit character.
    options.Password.RequireNonAlphanumeric = true; // Password should contain at least 1 nonalphanumeric character.
    options.Password.RequireUppercase = true; // Password should contain at least 1 uppercase character.
    options.Password.RequireLowercase = true; // Password should contain at least 1 lowercase character.
                                              //options.Password.RequiredUniqueChars // The characters that are not wanted to be reused.
    #endregion
    #region Hesap Kilitleme Ayarlarım
    options.Lockout.MaxFailedAccessAttempts = 3; // max failed login attempts
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15); //Waiting time required to log in to a locked account
    //options.Lockout.AllowedForNewUsers = true; // Allow a locked account to register again
    #endregion
    options.User.RequireUniqueEmail = true; // all emails can only be saved once
    options.SignIn.RequireConfirmedEmail = false; //email confirmation requirement 
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login"; 
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromSeconds(45);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security.Cookie",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IImageHelper, ImageHelper>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
