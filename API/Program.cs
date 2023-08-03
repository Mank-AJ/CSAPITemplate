using API.ServicesExtensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Add your Entension
///1. SQL Entiry Entity Framework Conneciton
///builder.Services.AddSQLEntityFrameworkConnection(builder);
///2. SQL AOD.Net Conneciton
///builder.Services.AddSQLConnection(builder);
///3. Swagger
///builder.Services....
///4. Identity
///builder.Services....



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
