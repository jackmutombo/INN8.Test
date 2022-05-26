using INN8_API.Extensions;
using INN8_API.Middleware;
using INN8_SBS.Extensions;
using INN8Lib.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddLibServices(configuration);
builder.Services.AddSBSServices(configuration);
builder.Services.AddSBSHttpClientFactory(configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddlerware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
