using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll", builder =>
                 builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
    );
    options.AddPolicy(
        "OnlyGetDelete", builder =>
                 builder.WithOrigins().AllowAnyHeader().WithMethods("Get","Delete")
    );

}
);

var app = builder.Build();



/*
 * Hvilke services man bruger
 */

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biler API v1.0");
        c.RoutePrefix = "api/help";
    });

}





app.UseAuthorization();

app.UseCors("OnlyGetDelete");

app.MapControllers();

app.Run();
