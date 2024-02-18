using Microsoft.EntityFrameworkCore;
using WEBAPIPractise;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<APIDBContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("ContactAPIConnectionString")));

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
app.UseEndpoints(endpoints => { 
    endpoints.MapControllers();

});

//app.MapControllers();

app.Run();
