using AutoMapper;
using Calculo.Domain.Entities;
using Calculo.Domain.Interfaces;
using Calculo.Infra.Externo;
using Calculo.Service.Servicos;
using CalculoAPI.Application.Models;
using Layer.Architecture.Service.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
                      policy =>
                      policy.WithOrigins("http://localhost:3000/")
                      .AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader());
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IServicoCalculoBase<Juros, ValidacaoJuros>, ServicoCalculoJuros>();
builder.Services.AddScoped<IServicoExternoBase, ServicoTaxaJuros>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSingleton(new MapperConfiguration(config =>
{
    config.CreateMap<JurosModel, Juros>();
    config.CreateMap<Juros, JurosModel>();
}).CreateMapper());

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
