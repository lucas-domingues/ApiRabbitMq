using ApiRabbitMq.Application.Services;
using ApiRabbitMq.Domain.Entities;
using ApiRabbitMq.Domain.Interfaces;
using ApiRabbitMq.Infrastructure.Context;
using ApiRabbitMq.Infrastructure.Messaging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configurar dependências
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddSingleton<RabbitMQConsumer>();

var app = builder.Build();

// Iniciar o Consumer
var consumer = app.Services.GetRequiredService<RabbitMQConsumer>();
Task.Run(() => consumer.StartAsync("product"));

app.Run();