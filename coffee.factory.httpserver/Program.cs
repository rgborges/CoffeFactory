using coffee.factory.httpserver.Services;

var db = new MemoryCoffeeFactoryDb();
var service = new MemoryCatalogService();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/catalog/", () => db.GetCoffees());
app.MapGet("/catalog/{id}", (int id) => db.GetCoffee(id));

app.Run();
