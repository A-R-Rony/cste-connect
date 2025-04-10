using CsteConnect.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//add services
builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("EmployeeDBConnection"),
        new MySqlServerVersion(new Version(8, 0, 3)) // Specify the MySQL version (adjust it accordingly)
    ));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.Run();