using minimal_api;
using minimal_api.Application;
using minimal_api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//Add controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

//Add minimal-api
//builder.Services.RegisterModules();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

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

app.Run();

