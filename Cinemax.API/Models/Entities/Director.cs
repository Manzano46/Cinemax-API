public class Director
{
    public int DirectorId {get; set;}
    public string Name {get; set;}    
    public virtual ICollection<MovieDirector>? MovieDirectors { get; set; }
}
