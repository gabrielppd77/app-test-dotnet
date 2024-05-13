using FirstApi.DataBase;

using FirstApi.Services;
using FirstApi.DataBase.Repositories;
using FirstApi.Exceptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PgContext>();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddScoped<FirstService>();

builder.Services.AddScoped<FirstRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapControllers();

app.UseHttpsRedirection();
app.UseExceptionHandler();

app.Run();