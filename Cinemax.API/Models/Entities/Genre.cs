namespace Cinemax.API.Models
{
    public class Genre
    {
        public int GenreId {get; set;}
        public string Name {get; set;}    
        public virtual ICollection<MovieGenre>? MovieGenres { get; set; }
    }
}
