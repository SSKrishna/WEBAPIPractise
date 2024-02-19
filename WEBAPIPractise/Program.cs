using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WEBAPIPractise;
using WEBAPIPractise.BLL.Implementation;
using WEBAPIPractise.BLL.Interface;
using WEBAPIPractise.DAL.Implementation;
using WEBAPIPractise.DAL.Interface;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DAL services
builder.Services.AddScoped<IProductDAL, ProductDAL>();


//BLL sevices
builder.Services.AddScoped<IProductBLL,ProductBLL>();
 

builder.Services.AddDbContext<APIDBContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("ContactAPIConnectionString")));

//// Configure JWT authentication
//    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//        .AddJwtBearer(options =>
//        {
//            options.TokenValidationParameters = new TokenValidationParameters
//            {
//                ValidateIssuer = true,
//                ValidateAudience = true,
//                ValidateLifetime = true,
//                ValidateIssuerSigningKey = true,
//                ValidIssuer = "yourIssuer",
//                ValidAudience = "yourAudience",
//                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("yourSecretKey"))
//            };
//        });

builder.Services.AddLogging(build =>

    build.AddProvider(new DatabaseLoggerProvider(builder.Configuration.GetConnectionString("ContactAPIConnectionString"))));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();


//Conventional routing setup
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();

});

//app.MapControllers();

app.Run();
