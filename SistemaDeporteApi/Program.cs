using Microsoft.EntityFrameworkCore;
using SistemaDeporteApi.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddEnvironmentVariables();

var ConStr = builder.Configuration.GetConnectionString("SqlConStr");

builder.Services.AddDbContext<Contexto>(options =>
    options.UseMySql(ConStr, new MySqlServerVersion(new Version(8, 0, 30))));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(builder => builder
    .AllowAnyOrigin()
        .AllowAnyMethod()
            .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
