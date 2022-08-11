
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAuthentication("Bearer")
    .AddIdentityServerAuthentication("Bearer", options =>
    {
        options.Authority = "https://localhost5443";
        options.ApiName = "ShopAPI";
    });


builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IShopService, ShopService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization(); 

app.MapControllers();

app.Run();
