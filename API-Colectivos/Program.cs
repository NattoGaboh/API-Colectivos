global using Microsoft.EntityFrameworkCore;
using API_Colectivos.Domain.IRepository;
using API_Colectivos.Domain.IServices;
using API_Colectivos.Persistence.Context;
using API_Colectivos.Persistence.Repository;
using API_Colectivos.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
//Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ILoginService, LoginService>();
//Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

