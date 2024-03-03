namespace Cinemax.API.Models
{
    public class MovieGenre
    {
        public int MovieGenreId {get; set;}
        public int GenreId {get; set;}
        public int MovieId {get; set;}
        public virtual Genre Genre {get; set;}
        public virtual Movie Movie {get; set;}
    }
}