using CrudGitFlow.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// El repositorio vive una sola vez mientras la app está corriendo
// (Singleton), para que los datos no se pierdan entre peticiones.
builder.Services.AddSingleton<ProductoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
