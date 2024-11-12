using AbstractFactory.Extensions;
using Builder.Extensions;
using DesignPatterns.Extensions;
using FactoryMethod.Extensions;
using Strategy.Extensions;
using TemplateMethod.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ConfigureJson());

builder.Services.ConfigureFactoryMethod();
builder.Services.ConfigureAbstractFactory();
builder.Services.ConfigureBuilderPattern();
builder.Services.ConfigureStrategy();
builder.Services.ConfigureTemplateMethod();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
