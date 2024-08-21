using Financial.Control.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerService();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
