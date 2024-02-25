public class Movie{
    public int MovieId {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}
    public TimeSpan Duration {get; set;}
    public DateOnly Premiere{get; set;}

    public virtual ICollection<Projection>? Projections { get; set; }
    public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    public virtual ICollection<MovieActor> MovieActors { get; set; }
    public virtual ICollection<MovieDirector> MovieDirectors { get; set; }
    public virtual ICollection<MovieCountry> MovieCountries { get; set; }
    
}