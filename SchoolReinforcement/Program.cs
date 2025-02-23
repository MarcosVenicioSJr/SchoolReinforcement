using SchoolReinforcement.Context;
using Microsoft.EntityFrameworkCore;
using SchoolReinforcement.Services;
using SchoolReinforcement.Interfaces.Service;
using SchoolReinforcement.Entities;
using SchoolReinforcement.Interfaces.Repository;
using SchoolReinforcement.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IService<Student>, StudentService>();
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<SchoolContext>();

builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolReforce")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
