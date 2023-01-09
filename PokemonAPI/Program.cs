using PokemonAPI.Interfaces;
using PokemonAPI.Profiles;
using PokemonAPI.Rest;
using PokemonAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PokemonService, PokemonService>();
builder.Services.AddSingleton<IPokemonService, PokemonService>();
builder.Services.AddSingleton<IPokemonApi, PokemonApiRest>();
builder.Services.AddAutoMapper(typeof(PokemonProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
