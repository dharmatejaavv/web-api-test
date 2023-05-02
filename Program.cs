using Microsoft.EntityFrameworkCore;
using web_api_test;
using web_api_test.Models;

var builder = WebApplication.CreateBuilder(args);
//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services); // calling ConfigureServices method
// Add services to the container.
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("Server=tcp:simple-web-storage.database.windows.net,1433;Initial Catalog=web-app-db;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";")
));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//startup.Configure(app, builder.Environment); // calling Configure method

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
