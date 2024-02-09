using Cinemax.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


var movies = new List<Movie>
{
    new Movie { Id = 1, Title = "The Shawshank Redemption", Year = 1994, Director = "Frank Darabont" },
    new Movie { Id = 2, Title = "The Godfather", Year = 1972, Director = "Francis Ford Coppola" },
};

app.MapGet("/movies", () => movies)
   .WithName("GetMovies")
   .WithOpenApi();

app.Run();
