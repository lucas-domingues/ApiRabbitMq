using ApiRabbitMq.Infrastructure.Context;
using ApiRabbitMq.Domain.Interfaces;
using ApiRabbitMq.Infrastructure.Messaging;
using ApiRabbitMq.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//registra os serviços no container
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IRabbitMQProducer, RabbitMQProducer>();


var app = builder.Build();

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