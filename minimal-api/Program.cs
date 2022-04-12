using minimal_api;
using minimal_api.Application;
using minimal_api.Application.Common.Interface;
using minimal_api.Application.Common.Model;
using minimal_api.Authorization;
using minimal_api.Infrastructure;
using minimal_api.Infrastructure.Persistance;
using minimal_api.Middleware;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Add controllers
builder.Services.AddControllers().AddJsonOptions(x =>
{
    // serialize enums as strings in api responses (e.g. Role)
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddScoped<IJWTUtils, JWTUtils>();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));


//Add minimal-api
//builder.Services.RegisterModules();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseMiddleware<ErrorHandleMiddleware>();
app.UseMiddleware<JWTMiddleware>();


//Add minimal-api
//app.MapEndpoints();

//Add controllers
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Seed the database on startup
using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
SeedDb.SeedDbOnStartUp(context);

app.Run();


