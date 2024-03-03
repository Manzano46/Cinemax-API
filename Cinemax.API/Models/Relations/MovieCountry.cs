namespace Cinemax.API.Models
{
    public class MovieCountry
    {
        public int MovieCountryId {get; set;}
        public int CountryId {get; set;}
        public int MovieId {get; set;}
        public virtual Country Country {get; set;}
        public virtual Movie Movie {get; set;}    
    }
}