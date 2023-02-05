using Taxas.Application.Interfaces;
using Taxas.Domain.Entidades;
using Taxas.Service;
using Taxas.Service.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
                      policy =>
                      policy.WithOrigins("*")
                      .AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IServicoTaxaBase<TaxaJurosCompostos>, ServicoTaxaJurosCompostos>();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
