
using Livraria_Api.Contexts;
using Livraria_Api.Interfaces;
using Livraria_Api.Middlewares;
using Livraria_Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("http://localhost:3000")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});


// Add services to the container.
builder.Services.AddDbContext<LivrariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

//Container de Teste unitário.
// builder.Services.AddDbContext<LivrariaContext>(opt =>
//     opt.UseInMemoryDatabase("ToDoLivrariaTest"));

builder.Services.AddControllers();
// Adicionar os serviços
builder.Services.AddScoped<ILivroService, LivroService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Livraria.Api", Version = "v1" } );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.UseMiddleware(typeof(ErrorMiddleware));

app.MapControllers();

app.Run();
