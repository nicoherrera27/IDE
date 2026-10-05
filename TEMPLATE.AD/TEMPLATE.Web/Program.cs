// Proyecto (asp.net core web api)
// Instala NuGET Swashbuckle.AspNetCore
// Referencia Domain

// Copiar Launch Settings in Properties

using TEMPLATE.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpLogging();

// Add Endpoints
app.MapClaseEndpoints();

app.Run();
