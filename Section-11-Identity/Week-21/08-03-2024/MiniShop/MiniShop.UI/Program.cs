using MiniShop.UI.Extensions;

var builder = WebApplication.CreateBuilder(args);

#region ServicesRegion
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextServices();
builder.Services.AddIdentityServices();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddRepositoryServices();
builder.Services.AddOtherServices();
#endregion

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

#region RouteRegion
app.MapControllerRoute(
    name: "products",
    pattern: "urunler/{categoryUrl}",
    defaults: new { controller = "Product", action = "Index" }
    );
app.MapAreaControllerRoute(
    name: "productsadmin",
    pattern: "yonteci/urunler/{isdeleted}",
    areaName: "Admin",
    defaults: new { area = "Admin", controller = "Product", action = "Index" });

//https://localhost:59079/yonteci/urunler/false şeklinde görünen url yapımızı false yerine "silinenurunler" şeklinde nasıl gösterebiliriz?

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion


app.UpdateDatabase().Run();
