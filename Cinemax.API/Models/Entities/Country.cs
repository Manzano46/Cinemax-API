public class Country
{
    public int CountryId {get; set;}
    public string Name {get; set;}   
    public virtual ICollection<MovieCountry> MovieCountries { get; set; } 
}
