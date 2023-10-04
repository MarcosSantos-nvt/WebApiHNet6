using Application.MapperSetup;
using Infra.CrossCutting.Ioc;
using Infra.CrossCutting.UtilsResources;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

NativeInjectorDependency.RegisterServices(builder.Services);

AutoMapperConfig.RegisterMappings();


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDataBaseConfiguration(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
