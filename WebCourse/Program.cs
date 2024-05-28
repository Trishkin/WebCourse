using Microsoft.EntityFrameworkCore;
using WebCourse.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().WithOrigins("http://localhost:4200", "https://localhost:4200"));

app.MapControllers();

app.Run();
