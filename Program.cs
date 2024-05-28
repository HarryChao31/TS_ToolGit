using TS_Tool.DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TS_Tool.Service.GetBetInfo;
using TS_Tool.Service.GetSWError;
using TS_Tool.Service.Repository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YY1GameProviderDbContext>(options => 
<<<<<<< HEAD
    options.UseSqlServer(builder.Configuration.GetConnectionString("FirstDatabaseConnection")));
builder.Services.AddDbContext<SecondDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SecondDatabaseConnection")));
=======
    options.UseSqlServer(builder.Configuration.GetConnectionString("YY1GameProviderDatabaseConnection")));
builder.Services.AddDbContext<YY1RecordDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("YY1RecordDatabaseConnection")));
>>>>>>> 7c8d334497b69686fa991f7bd841d2857d8d8432
builder.Services.AddDbContext<ThirdDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ThirdDatabaseConnection")));
builder.Services.AddDbContext<YY2GameProviderDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("YY2GameProviderDatabaseConnection")));
builder.Services.AddDbContext<YY2RecordDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("YY2RecordDatabaseConnection")));
builder.Services.AddDbContext<YY3GameProviderDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("YY3GameProviderDatabaseConnection")));
builder.Services.AddDbContext<YY3RecordDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("YY3RecordDatabaseConnection")));
builder.Services.AddScoped<IGetBetInfoService, GetBetInfoService>();
<<<<<<< HEAD
builder.Services.AddScoped<INewSystemGameProviderRepo, GetBetInfoRepository>();
=======
builder.Services.AddScoped(typeof(IGetBetInfoRepository<>), typeof(GetBetInfoRepository<>));
>>>>>>> 7c8d334497b69686fa991f7bd841d2857d8d8432
builder.Services.AddScoped<IGetSWErrorService, GetSWErrorService>();
builder.Services.AddScoped(typeof(IGetSWErrorRepository<>), typeof(GetSWErrorRepository<>));

builder.Services.AddScoped<IGetOSBetInfoByMixParlayBetRepository, GetOSBetInfoByMixParlayBetRepository>();
builder.Services.AddScoped<IGetOSBetInfoBySingleBetRepository, GetOSBetInfoBySingleBetRepository>();




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
